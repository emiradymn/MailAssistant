import { Routes, Route } from "react-router-dom";
import Auth from "./pages/Auth";
import UserProfile from "./pages/Profile";

export default function App() {
  return (
    <Routes>
      <Route path="/" element={<Auth />} />
      <Route path="/profile" element={<UserProfile />} />
    </Routes>
  );
}
