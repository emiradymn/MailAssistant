export default function MailSendButton({ onClick }) {
  return (
    <div className="pt-6 border-t border-gray-800">
      <button
        type="button"
        onClick={onClick}
        className="w-full py-3 rounded-lg bg-emerald-500/15 text-emerald-400
                   hover:bg-emerald-500/25 transition font-medium"
      >
        Mail Gönder
      </button>
    </div>
  );
}
