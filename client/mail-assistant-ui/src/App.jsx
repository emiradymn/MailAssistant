import { Routes, Route, Navigate } from "react-router-dom";
import Auth from "./pages/Auth";
import UserProfile from "./pages/Profile";
import DashboardLayout from "./pages/DashboardLayout";
import Templates from "./pages/Templates";

export default function App() {
  return (
    <Routes>
      {/* DEFAULT */}
      <Route path="/" element={<Navigate to="/auth" replace />} />

      {/* AUTH */}
      <Route path="/auth" element={<Auth />} />

      {/* DASHBOARD */}
      <Route element={<DashboardLayout />}>
        <Route path="profile" element={<UserProfile />} />
      </Route>
      <Route element={<DashboardLayout />}>
        <Route path="templates" element={<Templates />}></Route>
      </Route>
    </Routes>
  );
}
