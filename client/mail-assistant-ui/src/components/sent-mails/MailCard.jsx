export default function MailCard({ mail, onClick }) {
  return (
    <div
      onClick={onClick}
      className={`relative flex gap-4 bg-gray-900/60 border border-gray-800 rounded-2xl p-5
                  transition cursor-pointer
                  hover:bg-gray-900
                  ${
                    mail.status === "success"
                      ? "hover:border-emerald-500/40"
                      : "hover:border-red-500/40"
                  }`}
    >
      {/* STATUS BAR */}
      <div
        className={`w-1 rounded-full ${
          mail.status === "success" ? "bg-emerald-500" : "bg-red-500"
        }`}
      />

      {/* CONTENT */}
      <div className="flex-1 space-y-2">
        <div className="flex justify-between items-start">
          <div>
            <p className="text-white font-medium">{mail.title}</p>
            <p className="text-sm text-gray-400">{mail.to}</p>
          </div>

          <span className="text-xs text-gray-400">{mail.date}</span>
        </div>

        <p className="text-sm text-gray-400 line-clamp-2">{mail.preview}</p>

        <div className="flex items-center gap-3 pt-2">
          <span
            className={`px-3 py-1 rounded-full text-xs
              ${
                mail.status === "success"
                  ? "bg-emerald-500/10 text-emerald-400"
                  : "bg-red-500/10 text-red-400"
              }`}
          >
            {mail.status === "success" ? "✔ Gönderildi" : "✖ Gönderilemedi"}
          </span>

          {mail.extra && (
            <span className="text-xs text-gray-500">{mail.extra}</span>
          )}
        </div>
      </div>
    </div>
  );
}
