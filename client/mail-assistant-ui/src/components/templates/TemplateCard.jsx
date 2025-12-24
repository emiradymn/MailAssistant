export default function TemplateCard({ template, onPreview }) {
  return (
    <div
      className="group bg-gray-900/70 border border-gray-800 rounded-2xl overflow-hidden
                 hover:-translate-y-1 hover:border-emerald-500/40
                 hover:shadow-xl hover:shadow-emerald-500/5
                 transition-all duration-300"
    >
      {/* PREVIEW */}
      <div className="relative bg-gray-950 p-5 text-xs text-gray-300 font-mono h-32">
        <p className="line-clamp-6 whitespace-pre-line">{template.content}</p>
        <div className="absolute bottom-0 left-0 w-full h-12 bg-gradient-to-t from-gray-950 to-transparent" />
      </div>

      {/* BODY */}
      <div className="p-6">
        <h3 className="text-lg font-medium">{template.title}</h3>
        <span className="text-xs text-emerald-400">{template.category}</span>

        <p className="text-sm text-gray-400 mt-3">{template.description}</p>

        <div className="mt-6 flex gap-3">
          <button
            onClick={onPreview}
            className="flex-1 px-4 py-2 rounded-lg bg-gray-800 hover:bg-gray-700 text-sm transition"
          >
            Önizle
          </button>

          <button className="flex-1 px-4 py-2 rounded-lg bg-emerald-500/15 text-emerald-400 hover:bg-emerald-500/25 text-sm transition">
            Şimdi Kullan
          </button>
        </div>
      </div>
    </div>
  );
}
