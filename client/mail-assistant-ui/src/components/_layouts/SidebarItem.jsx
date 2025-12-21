export default function SidebarItem({ icon, label, onClick, active, danger }) {
  return (
    <button
      onClick={onClick}
      className={`
        group w-full flex items-center gap-3 px-4 py-2.5 rounded-xl
        text-sm font-medium transition-all duration-200
        ${
          active
            ? "bg-emerald-500/10 text-emerald-400"
            : danger
            ? "text-red-400 hover:bg-red-500/10"
            : "text-gray-300 hover:bg-gray-800/70 hover:text-white"
        }
      `}
    >
      <span
        className={`transition-transform duration-200 ${
          active ? "scale-105" : "group-hover:scale-105"
        }`}
      >
        {icon}
      </span>

      <span className="flex-1 text-left">{label}</span>

      {/* Active Indicator */}
      {active && <span className="w-1.5 h-1.5 rounded-full bg-emerald-400" />}
    </button>
  );
}
