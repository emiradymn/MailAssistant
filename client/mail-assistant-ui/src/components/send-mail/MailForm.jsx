export default function MailForm({
  template,
  params,
  mailData,
  signature,
  onMailDataChange,
  onParamChange,
  onSignatureChange,
  onFileChange,
  onSubmit, // ✅ EKLENDİ
}) {
  if (!template) return null;

  return (
    <section className="p-10 flex flex-col justify-between overflow-y-auto">
      <div>
        <h2 className="text-xl font-semibold mb-6">Mail Bilgileri</h2>

        {/* SABİT ALANLAR */}
        <div className="space-y-4 mb-8">
          {/* Gönderen */}
          <input
            placeholder="Gönderen Mail"
            value={mailData.from}
            onChange={(e) => onMailDataChange("from", e.target.value)}
            className="w-full px-4 py-2 rounded-lg bg-gray-950 border border-gray-800"
          />

          {/* Alıcı */}
          <input
            placeholder="Alıcı Mail"
            value={mailData.to}
            onChange={(e) => onMailDataChange("to", e.target.value)}
            className="w-full px-4 py-2 rounded-lg bg-gray-950 border border-gray-800"
          />

          {/* Konu */}
          <input
            placeholder="Konu"
            value={mailData.subject}
            onChange={(e) => onMailDataChange("subject", e.target.value)}
            className="w-full px-4 py-2 rounded-lg bg-gray-950 border border-gray-800"
          />
          {/* 🔥 SIGNATURE */}
          <div className="mb-8">
            <label className="block text-sm text-gray-400 mb-1">İmza</label>

            <textarea
              value={signature}
              onChange={(e) => onSignatureChange(e.target.value)}
              rows={4}
              className="w-full px-4 py-2 rounded-lg bg-gray-950 border border-gray-800"
            />
          </div>

          {/* Dosya */}
          <div>
            <label className="block text-sm text-gray-400 mb-1">Ek Dosya</label>
            <input
              type="file"
              className="w-full text-sm text-gray-400
                       file:mr-4 file:py-2 file:px-4
                       file:rounded-lg file:border-0
                       file:bg-emerald-500/15 file:text-emerald-400
                       hover:file:bg-emerald-500/25 transition"
              onChange={(e) => onFileChange(e.target.files[0])}
            />
          </div>
        </div>

        {/* PARAMETRELER */}
        <div>
          <h3 className="text-lg font-medium mb-4">Şablon Parametreleri</h3>

          {Object.keys(params).map((key) => (
            <div key={key} className="mb-4">
              <label className="block text-sm text-gray-400 mb-1">{key}</label>

              <input
                placeholder={`{{${key}}}`}
                value={params[key]}
                onChange={(e) => onParamChange(key, e.target.value)}
                className="w-full px-4 py-2 rounded-lg bg-gray-950 border border-gray-800
                   focus:outline-none focus:border-emerald-500/40 transition"
              />
            </div>
          ))}
        </div>
      </div>

      {/* GÖNDER BUTONU */}
      <button
        onClick={onSubmit}
        className="mt-6 w-full py-3 rounded-lg
                   bg-emerald-500/15 text-emerald-400
                   hover:bg-emerald-500/25 transition font-medium"
      >
        Mail Gönder
      </button>
    </section>
  );
}
