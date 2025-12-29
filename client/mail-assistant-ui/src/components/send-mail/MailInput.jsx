export default function MailInput({ label, placeholder, type = "text" }) {
  return (
    <div>
      {label && <label className="text-sm text-gray-400">{label}</label>}
      <input
        type={type}
        placeholder={placeholder}
        className={`mt-2 w-full rounded-lg bg-gray-950 border border-gray-800
                    px-4 py-3 focus:outline-none focus:border-emerald-500/40 transition`}
      />
    </div>
  );
}
