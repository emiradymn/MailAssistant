import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

import CategoryFilter from "../components/templates/CategoryFilter";
import TemplateCard from "../components/templates/TemplateCard";
import TemplatePreviewModal from "../components/templates/TemplatePreviewModal";
import { getEmailTemplates } from "../services/emailTemplateService";

export default function Templates() {
  const [templates, setTemplates] = useState([]);
  const [selectedTemplate, setSelectedTemplate] = useState(null);
  const [activeCategoryId, setActiveCategoryId] = useState(null);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);

  const navigate = useNavigate();

  // ✅ DOĞRU EVENT HANDLER
  const handleUseTemplate = (template) => {
    navigate(`/send-mail/${template.id}`);
  };

  // DATA FETCH
  useEffect(() => {
    const fetchTemplates = async () => {
      try {
        setLoading(true);
        setError(null);

        const data = await getEmailTemplates(activeCategoryId);

        const mapped = data.map((t) => ({
          id: t.id,
          title: t.title,
          description: t.description,
          content: t.body,
          category: t.categoryName,
        }));

        setTemplates(mapped);
      } catch (err) {
        setError("Şablonlar yüklenemedi");
      } finally {
        setLoading(false);
      }
    };

    fetchTemplates();
  }, [activeCategoryId]);

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
      <CategoryFilter
        active={activeCategoryId}
        onChange={setActiveCategoryId}
      />

      {/* STATUS */}
      {loading && <p className="text-gray-400 mt-6">Yükleniyor...</p>}
      {error && <p className="text-red-400 mt-6">{error}</p>}

      {!loading && templates.length === 0 && (
        <p className="text-gray-500 mt-6">Şablon bulunamadı</p>
      )}

      {/* LIST */}
      <div className="grid grid-cols-1 md:grid-cols-2 xl:grid-cols-3 gap-8 mt-10">
        {templates.map((template) => (
          <TemplateCard
            key={template.id}
            template={template}
            onPreview={() => setSelectedTemplate(template)}
            onUse={handleUseTemplate}
          />
        ))}
      </div>

      {/* MODAL */}
      {selectedTemplate && (
        <TemplatePreviewModal
          template={selectedTemplate}
          onClose={() => setSelectedTemplate(null)}
          onUse={() => handleUseTemplate(selectedTemplate)}
        />
      )}
    </div>
  );
}
