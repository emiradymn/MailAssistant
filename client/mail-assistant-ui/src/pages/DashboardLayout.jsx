import { Outlet } from "react-router-dom";
import Sidebar from "../components/_layouts/Sidebar";

export default function DashboardLayout() {
  return (
    <div className="min-h-screen flex bg-gray-950 text-white">
      <Sidebar />

      <main className="flex-1 p-6 overflow-y-auto">
        <Outlet /> {/* RenderBody */}
      </main>
    </div>
  );
}
