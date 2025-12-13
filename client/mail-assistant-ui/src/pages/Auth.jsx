import { useState } from "react";
import { motion } from "framer-motion";
import LoginForm from "../components/auth/LoginForm";
import RegisterForm from "../components/auth/RegisterForm";
import AuthSwitcher from "../components/auth/AuthSwitcher";

export default function Auth() {
  const [isLogin, setIsLogin] = useState(true);

  return (
    <div className="min-h-screen flex items-center justify-center bg-gray-950 p-4 relative overflow-hidden">
      <div className="w-full max-w-5xl grid grid-cols-1 md:grid-cols-2 bg-gray-900/60 backdrop-blur-xl rounded-3xl overflow-hidden shadow-2xl border border-gray-800/60">
        {/* LEFT PANEL */}
        <div className="hidden md:flex flex-col items-center justify-center relative p-10 text-white bg-gradient-to-b from-emerald-800/40 to-teal-900/40 backdrop-blur-xl">
          <div className="max-w-xs text-center p-4 bg-white/5 border border-emerald-500/10 rounded-2xl">
            <h3 className="text-xl font-semibold text-white mb-2">
              Web & Kodlama
            </h3>
            <p className="text-gray-300 text-sm">
              Modern uygulamalar için güçlü backend ve temiz kodla hızlıca
              başlayın.
            </p>
          </div>
        </div>

        {/* RIGHT PANEL */}
        <motion.div
          initial={{ opacity: 0, x: 40 }}
          animate={{ opacity: 1, x: 0 }}
          transition={{ duration: 0.5 }}
          className="p-12 bg-gray-900/60 backdrop-blur-xl"
        >
          <AuthSwitcher isLogin={isLogin} setIsLogin={setIsLogin} />

          {isLogin ? <LoginForm /> : <RegisterForm />}
        </motion.div>
      </div>
    </div>
  );
}
