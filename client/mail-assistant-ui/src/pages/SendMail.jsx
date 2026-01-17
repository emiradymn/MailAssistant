import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import axios from "axios";
import { toast } from "react-toastify";

import MailLayout from "../components/send-mail/MailLayout";
import TemplatePreview from "../components/send-mail/TemplatePreview";
import MailForm from "../components/send-mail/MailForm";
import MailSendButton from "../components/send-mail/MailSendButton";
import { extractPlaceholders } from "../utils/templateParser";
import { getMyProfile } from "../services/userProfileService";

export default function SendMail() {
  const { templateId } = useParams();
  const token = localStorage.getItem("token");

  const [template, setTemplate] = useState(null);
  const [params, setParams] = useState({});
  const [signature, setSignature] = useState("");
  const [mailData, setMailData] = useState({
    from: "",
    to: "",
    subject: "",
  });
  const [file, setFile] = useState(null);

  const handleMailDataChange = (key, value) => {
    setMailData((prev) => ({ ...prev, [key]: value }));
  };

  const handleParamChange = (key, value) => {
    setParams((prev) => ({ ...prev, [key]: value }));
  };

  const handleSendMail = async () => {
    console.log("MAIL GÖNDER TIKLANDI");

    if (!template) return;

    const formData = new FormData();
    formData.append("templateId", template.id);
    formData.append("from", mailData.from);
    formData.append("to", mailData.to);
    formData.append("subject", mailData.subject);
    formData.append("signature", signature);

    Object.keys(params).forEach((key) => {
      formData.append(`params[${key}]`, params[key]);
    });

    if (file) {
      formData.append("file", file);
    }

    await axios.post("http://localhost:5252/api/mails/send", formData, {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    try {
      await handleSendMail();
      toast.success("Mail başarıyla gönderildi ✅");
    } catch (error) {
      console.error(error);
      toast.error("Mail gönderilirken hata oluştu ❌");
    }
  };

  useEffect(() => {
    const fetchData = async () => {
      const templateRes = await axios.get(
        `http://localhost:5252/api/email-templates/${templateId}`
      );

      const templateData = templateRes.data;
      setTemplate(templateData);

      const placeholders = extractPlaceholders(templateData.body);
      const initialParams = {};

      placeholders.forEach((p) => {
        if (p !== "Signature") initialParams[p] = "";
      });

      setParams(initialParams);

      const profile = await getMyProfile();

      setMailData((prev) => ({
        ...prev,
        from: profile.email ?? "",
      }));

      setSignature(profile.defaultSignature ?? "");
    };

    if (templateId) fetchData();
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
      <MailSendButton onClick={handleSubmit} />
    </MailLayout>
  );
}
