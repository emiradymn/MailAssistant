import { useState } from "react";
import CategoryFilter from "../components/templates/CategoryFilter";
import TemplateCard from "../components/templates/TemplateCard";
import TemplatePreviewModal from "../components/templates/TemplatePreviewModal";

const TEMPLATES = [
  {
    id: 1,
    title: "İş Başvurusu",
    category: "İş",
    description:
      "Profesyonel ve resmi iş başvuruları için hazırlanmış mail şablonu.",
    content: `Sayın Yetkili,

Şirketinizde açılan pozisyon için başvuruda bulunmak istiyorum.
Özgeçmişimi değerlendirebilirseniz memnun olurum.

İyi çalışmalar.`,
  },
  {
    id: 2,
    title: "Staj Başvurusu",
    category: "Staj",
    description: "Öğrenciler için sade ve etkili staj başvurusu maili.",
    content: `Merhaba,

Ben ... Üniversitesi öğrencisiyim.
Staj başvurusu için mail atıyorum.

İyi çalışmalar.`,
  },
];

export default function Templates() {
  const [selectedTemplate, setSelectedTemplate] = useState(null);
  const [activeCategory, setActiveCategory] = useState("Tümü");

  const filteredTemplates =
    activeCategory === "Tümü"
      ? TEMPLATES
      : TEMPLATES.filter((t) => t.category === activeCategory);

  return (
    <div className="p-10 bg-gray-950 max-w-7xl mx-auto text-white">
      {/* HEADER */}
      <div className="mb-12">
        <h1 className="text-4xl font-semibold text-emerald-400">
          Mail Şablonları
        </h1>
        <p className="text-sm text-gray-400 mt-2 max-w-xl">
          Profesyonel e-posta şablonlarını incele, önizle ve tek tıkla kullan.
        </p>
      </div>

      {/* CATEGORY */}
      <CategoryFilter active={activeCategory} onChange={setActiveCategory} />

      {/* LIST */}
      <div className="grid grid-cols-1 md:grid-cols-2 xl:grid-cols-3 gap-8 mt-10">
        {filteredTemplates.map((template) => (
          <TemplateCard
            key={template.id}
            template={template}
            onPreview={() => setSelectedTemplate(template)}
          />
        ))}
      </div>

      {/* MODAL */}
      {selectedTemplate && (
        <TemplatePreviewModal
          template={selectedTemplate}
          onClose={() => setSelectedTemplate(null)}
        />
      )}
    </div>
  );
}
