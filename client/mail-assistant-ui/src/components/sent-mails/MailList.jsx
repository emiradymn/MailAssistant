import { useState } from "react";
import MailCard from "./MailCard";
import MailPreviewModal from "./MailPreviewModal";

export default function MailList() {
  const [selectedMail, setSelectedMail] = useState(null);

  const mails = [
    {
      id: 1,
      title: "Ödeme Talebi",
      to: "mehmet.kaya@mail.com",
      date: "12 Oca 2026 · 14:32",
      preview:
        "12345 numaralı faturaya ait ödemenin tarafımıza iletilmesini rica ederiz.",
      content: `Merhaba Mehmet Bey,

12345 numaralı faturaya ait ödemenin
tarafımıza iletilmesini rica ederiz.

Bilgilerinize sunarız.

Mehmet Kaya`,
      status: "success",
      extra: "Template: Finans",
    },
    {
      id: 2,
      title: "İş Başvurusu",
      to: "ayse.demir@mail.com",
      date: "10 Oca 2026 · 09:18",
      preview:
        "Yazılım geliştirici pozisyonu için başvurumu bilgilerinize sunarım.",
      content: `Merhaba,

Yazılım geliştirici pozisyonu için
başvurumu bilgilerinize sunarım.

İyi çalışmalar.`,
      status: "error",
      extra: "SMTP timeout",
    },
  ];

  return (
    <>
      <div className="space-y-4">
        {mails.map((mail) => (
          <MailCard
            key={mail.id}
            mail={mail}
            onClick={() => setSelectedMail(mail)}
          />
        ))}
      </div>

      <MailPreviewModal
        mail={selectedMail}
        onClose={() => setSelectedMail(null)}
      />
    </>
  );
}
