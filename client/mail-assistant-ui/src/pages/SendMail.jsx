import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import axios from "axios";

import MailLayout from "../components/send-mail/MailLayout";
import TemplatePreview from "../components/send-mail/TemplatePreview";
import MailForm from "../components/send-mail/MailForm";

export default function SendMail() {
  const { templateId } = useParams();
  const [template, setTemplate] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchTemplate = async () => {
      try {
        setLoading(true);
        const res = await axios.get(
          `http://localhost:5252/api/email-templates/${templateId}`
        );
        setTemplate(res.data);
      } catch (err) {
        setError("Şablon yüklenemedi");
      } finally {
        setLoading(false);
      }
    };

    fetchTemplate();
  }, [templateId]);

  if (loading) {
    return <div className="text-gray-400 p-10">Yükleniyor...</div>;
  }

  if (error) {
    return <div className="text-red-400 p-10">{error}</div>;
  }

  return (
    <MailLayout>
      <TemplatePreview template={template} />
      <MailForm template={template} />
    </MailLayout>
  );
}
