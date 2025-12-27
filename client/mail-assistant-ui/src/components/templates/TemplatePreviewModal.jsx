export default function TemplatePreviewModal({ template, onClose, onUse }) {
  return (
    <div className="fixed inset-0 bg-black/70 backdrop-blur-sm flex items-center justify-center z-50">
      <div className="bg-gray-900 border border-gray-800 rounded-2xl w-full max-w-2xl p-6 shadow-2xl">
        {/* HEADER */}
        <div className="flex justify-between items-center mb-5">
          <div>
            <h2 className="text-xl font-semibold text-emerald-400">
              {template.title}
            </h2>
            <p className="text-xs text-gray-400">Mail Önizleme</p>
          </div>

          <button
            onClick={onClose}
            className="w-8 h-8 rounded-full bg-gray-800 hover:bg-gray-700"
          >
            ✕
          </button>
        </div>

        {/* CONTENT */}
        <div className="bg-gray-950 border border-gray-800 rounded-xl p-5 text-sm text-gray-300 font-mono whitespace-pre-line">
          {template.content}
        </div>

        {/* FOOTER */}
        <div className="mt-6 flex justify-end gap-3">
          <button
            onClick={onClose}
            className="px-4 py-2 rounded-lg bg-gray-800 hover:bg-gray-700"
          >
            Kapat
          </button>

          <button
            onClick={() => onUse(template)}
            className="px-4 py-2 rounded-lg bg-emerald-500 text-black font-medium"
          >
            Şimdi Kullan
          </button>
        </div>
      </div>
    </div>
  );
}
