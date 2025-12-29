export default function TemplatePreview({ template }) {
  if (!template) return null;

  return (
    <section className="bg-gray-950 p-10 overflow-y-auto">
      <h2 className="text-xl font-semibold mb-6">Şablon Önizleme</h2>

      <div className="bg-gray-900/70 border border-gray-800 rounded-2xl overflow-hidden">
        <div className="p-8 text-sm font-mono text-gray-300 whitespace-pre-line leading-relaxed">
          {template.body}
        </div>
      </div>
    </section>
  );
}
