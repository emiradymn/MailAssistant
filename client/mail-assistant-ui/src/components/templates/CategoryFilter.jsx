import { useEffect, useState } from "react";
import { getEmailTemplateCategories } from "../../services/emailTemplateCategoryService";

export default function CategoryFilter({ active, onChange }) {
  const [categories, setCategories] = useState([]);

  useEffect(() => {
    const fetchCategories = async () => {
      const data = await getEmailTemplateCategories();

      setCategories([{ id: null, name: "Tümü" }, ...data]);
    };

    fetchCategories();
  }, []);

  return (
    <div className="flex flex-wrap gap-3">
      {categories.map((category) => (
        <button
          key={category.id ?? "all"}
          onClick={() => onChange(category.id)}
          className={`
            px-5 py-2 rounded-full text-sm font-medium transition
            ${
              active === category.id
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
