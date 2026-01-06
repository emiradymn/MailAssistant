export default function TemplatePreview({ template, params, signature }) {
  if (!template) return null;

  let previewText = template.body;

  // 🔥 Signature replace (parametre DEĞİL)
  previewText = previewText.replace(
    /{{\s*Signature\s*}}/g,
    signature || "{{Signature}}"
  );

  // 🔁 Diğer parametreler
  Object.entries(params).forEach(([key, value]) => {
    const regex = new RegExp(`{{\\s*${key}\\s*}}`, "g");
    previewText = previewText.replace(regex, value || `{{${key}}}`);
  });

  return (
    <section className="bg-gray-950 p-10 overflow-y-auto">
      <h2 className="text-xl font-semibold mb-6">Şablon Önizleme</h2>

      <div className="bg-gray-900/70 border border-gray-800 rounded-2xl">
        <div className="p-8 text-sm font-mono text-gray-300 whitespace-pre-line leading-relaxed">
          {previewText}
        </div>
      </div>
    </section>
  );
}
