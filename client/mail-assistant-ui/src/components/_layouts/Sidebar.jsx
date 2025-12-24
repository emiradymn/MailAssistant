import SidebarItem from "./SidebarItem";
import {
  LayoutDashboard,
  FileText,
  Mail,
  LogOut,
  Sparkles,
} from "lucide-react";
import { useNavigate, useLocation } from "react-router-dom";

export default function Sidebar() {
  const navigate = useNavigate();
  const location = useLocation();

  return (
    <aside className="w-72 h-screen bg-gray-900/80 backdrop-blur-xl border-r border-gray-800 px-6 py-8 flex flex-col">
      {/* LOGO */}
      <div className="mb-12">
        <h1 className="text-2xl font-semibold text-emerald-400 tracking-tight">
          MailAssistant
        </h1>
        <p className="text-xs text-gray-400 mt-1">Dashboard</p>
      </div>

      {/* MENU */}
      <nav className="flex-1 space-y-1">
        <SidebarItem
          icon={<LayoutDashboard size={18} />}
          label="Profil"
          active={location.pathname === "/profile"}
          onClick={() => navigate("/profile")}
        />

        <SidebarItem
          icon={<Sparkles size={18} />}
          label="Hazır Şablonlar"
          active={location.pathname === "/templates"}
          onClick={() => navigate("/templates")}
        />

        <SidebarItem
          icon={<FileText size={18} />}
          label="Şablonlarım"
          active={location.pathname === "/my-templates"}
          onClick={() => navigate("/my-templates")}
        />

        <SidebarItem
          icon={<Mail size={18} />}
          label="Gönderilen Mailler"
          active={location.pathname === "/sent-mails"}
          onClick={() => navigate("/sent-mails")}
        />
      </nav>

      {/* FOOTER */}
      <div className="pt-6 border-t border-gray-800">
        <SidebarItem
          icon={<LogOut size={18} />}
          label="Çıkış Yap"
          danger
          onClick={() => {
            localStorage.removeItem("token");
            navigate("/auth", { replace: true });
          }}
        />
      </div>
    </aside>
  );
}
