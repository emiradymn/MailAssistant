import MailInput from "./MailInput";
import MailSendButton from "./MailSendButton";

export default function MailForm() {
  return (
    <section className="p-10 flex flex-col justify-between">
      <div>
        <h2 className="text-xl font-semibold mb-6">Mail Parametreleri</h2>

        <div className="space-y-5">
          <MailInput label="Alıcı" placeholder="hr@firma.com" type="email" />
          <MailInput label="Konu" placeholder="İş Başvurusu" />

          <div>
            <label className="text-sm text-gray-400">
              Şablon Parametreleri
            </label>

            <div className="mt-3 space-y-3">
              <MailInput placeholder="UserName" />
              <MailInput placeholder="CompanyName" />
              <MailInput placeholder="Position" />
            </div>
          </div>
        </div>
      </div>

      <MailSendButton />
    </section>
  );
}
