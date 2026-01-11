import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import axios from "axios";

import MailLayout from "../components/send-mail/MailLayout";
import TemplatePreview from "../components/send-mail/TemplatePreview";
import MailForm from "../components/send-mail/MailForm";
import { extractPlaceholders } from "../utils/templateParser";
import { getMyProfile } from "../services/userProfileService";

export default function SendMail() {
  const { templateId } = useParams();

  const [template, setTemplate] = useState(null);
  const [params, setParams] = useState({});
  const [signature, setSignature] = useState("");
  const [mailData, setMailData] = useState({
    from: "",
    to: "",
    subject: "",
  });
  const [file, setFile] = useState(null);

  /* SABİT MAIL ALANLARI */
  const handleMailDataChange = (key, value) => {
    setMailData((prev) => ({
      ...prev,
      [key]: value,
    }));
  };

  /* DİNAMİK PARAMETRELER */
  const handleParamChange = (key, value) => {
    setParams((prev) => ({
      ...prev,
      [key]: value,
    }));
  };

  const handleSendMail = async () => {
    if (!template) return;

    try {
      const formData = new FormData();

      formData.append("templateId", template.id);
      formData.append("from", mailData.from);
      formData.append("to", mailData.to);
      formData.append("subject", mailData.subject);

      // params
      Object.keys(params).forEach((key) => {
        formData.append(`params[${key}]`, params[key]);
      });

      // file
      if (file) {
        formData.append("file", file);
      }

      await axios.post("http://localhost:5252/api/mails/send", formData, {
        headers: {
          "Content-Type": "multipart/form-data",
        },
      });

      alert("Mail başarıyla gönderildi ✅");
    } catch (error) {
      console.error("Mail gönderilemedi:", error);
      alert("Mail gönderilirken hata oluştu ❌");
    }
  };

  /* TEMPLATE ÇEKME */
  useEffect(() => {
    const fetchData = async () => {
      try {
        /* 1️⃣ TEMPLATE */
        const templateRes = await axios.get(
          `http://localhost:5252/api/email-templates/${templateId}`
        );

        const templateData = templateRes.data;
        setTemplate(templateData);

        const placeholders = extractPlaceholders(templateData.body);

        const initialParams = {};
        placeholders.forEach((p) => {
          if (p !== "Signature") {
            initialParams[p] = "";
          }
        });

        setParams(initialParams);

        /* 2️⃣ USER PROFILE (mail + signature) */
        const profile = await getMyProfile();

        setMailData((prev) => ({
          ...prev,
          from: profile.email ?? "",
        }));

        setSignature(profile.defaultSignature ?? "");
      } catch (error) {
        console.error("Veriler alınamadı:", error);
      }
    };

    if (templateId) {
      fetchData();
    }
  }, [templateId]);

  return (
    <MailLayout>
      <TemplatePreview
        template={template}
        params={params}
        signature={signature}
      />

      <MailForm
        template={template}
        params={params}
        mailData={mailData}
        signature={signature}
        onSignatureChange={setSignature}
        onMailDataChange={handleMailDataChange}
        onParamChange={handleParamChange}
        onFileChange={setFile}
      />
    </MailLayout>
  );
}
