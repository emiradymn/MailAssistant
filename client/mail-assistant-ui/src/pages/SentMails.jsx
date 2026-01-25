import MailList from "../components/sent-mails/MailList";

export default function SentMails() {
  return (
    <div className="max-w-5xl mx-auto space-y-8">
      {/* HEADER */}
      <div className="flex items-center justify-between">
        <div>
          <h1 className="text-3xl font-semibold text-white">
            Gönderilen Mailler
          </h1>
          <p className="text-sm text-gray-400">Mail geçmişiniz</p>
        </div>

        <button className="px-4 py-2 bg-emerald-600 rounded-xl text-sm font-medium hover:bg-emerald-500">
          + Yeni Mail
        </button>
      </div>

      {/* LIST */}
      <MailList />
    </div>
  );
}
