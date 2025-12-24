const categories = ["Tümü", "İş", "Staj", "Toplantı"];

export default function CategoryFilter({ active, onChange }) {
  return (
    <div className="flex flex-wrap gap-3">
      {categories.map((category) => (
        <button
          key={category}
          onClick={() => onChange(category)}
          className={`
            px-5 py-2 rounded-full text-sm font-medium transition
            ${
              active === category
                ? "bg-emerald-500/15 text-emerald-400 ring-1 ring-emerald-500/30"
                : "bg-gray-900/80 text-gray-300 ring-1 ring-gray-800 hover:bg-gray-800"
            }
          `}
        >
          {category}
        </button>
      ))}
    </div>
  );
}
