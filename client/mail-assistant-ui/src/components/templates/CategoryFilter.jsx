import { useEffect, useState } from "react";
import { getEmailTemplateCategories } from "../../services/emailTemplateCategoryService";
export default function CategoryFilter({ active, onChange }) {
  const [categories, setCategories] = useState([]);

  useEffect(() => {
    getEmailTemplateCategories()
      .then((data) => {
        setCategories([{ id: "all", name: "Tümü" }, ...data]);
      })
      .catch(console.error);
  }, []);

  return (
    <div className="flex flex-wrap gap-3">
      {categories.map((category) => (
        <button
          key={category.id}
          onClick={() => onChange(category.name)}
          className={`
            px-5 py-2 rounded-full text-sm font-medium transition
            ${
              active === category.name
                ? "bg-emerald-500/15 text-emerald-400 ring-1 ring-emerald-500/30"
                : "bg-gray-900/80 text-gray-300 ring-1 ring-gray-800 hover:bg-gray-800"
            }
          `}
        >
          {category.name}
        </button>
      ))}
    </div>
  );
}
