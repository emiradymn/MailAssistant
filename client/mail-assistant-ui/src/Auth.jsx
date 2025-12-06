import { useState } from "react";
import { motion } from "framer-motion";

export default function Auth() {
  const [isLogin, setIsLogin] = useState(true);

  // FORM STATES
  const [fullName, setFullName] = useState("");
  const [userName, setUserName] = useState("");
  const [phoneNumber, setPhoneNumber] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");

  const [message, setMessage] = useState("");

  // 📌 API URL
  const API_URL = "http://localhost:5252/api/auth";

  // 📌 HANDLE SUBMIT
  const handleSubmit = async (e) => {
    e.preventDefault();
    setMessage("");

    // Register şifre doğrulaması
    if (!isLogin && password !== confirmPassword) {
      setMessage("Şifreler eşleşmiyor!");
      return;
    }

    // LOGIN PAYLOAD
    const loginPayload = {
      userNameOrEmail: email,
      password,
    };

    // REGISTER PAYLOAD → DTO ile birebir
    const registerPayload = {
      fullName,
      userName,
      email,
      phoneNumber,
      password,
      confirmPassword,
    };

    const payload = isLogin ? loginPayload : registerPayload;

    // Endpoint seçimi
    const endpoint = isLogin ? `${API_URL}/login` : `${API_URL}/register`;

    try {
      const res = await fetch(endpoint, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(payload),
      });

      const data = await res.json();

      // ❌ Başarısız
      if (!res.ok) {
        if (data.message) {
          setMessage("E-posta veya şifre hatalı!");
          return;
        }

        if (data.errors && data.errors.length > 0) {
          setMessage(data.errors.join(" | "));
          return;
        }

        setMessage("İşlem başarısız!");
        return;
      }

      // ✔ Login başarılı
      if (isLogin && data.token) {
        localStorage.setItem("token", data.token);
        setMessage("Giriş başarılı! 🎉");
      }

      // ✔ Register başarılı
      if (!isLogin) {
        setMessage("Kayıt başarılı! ✔");
      }
    } catch (err) {
      setMessage("Sunucuya bağlanılamıyor!");
    }
  };

  return (
    <div className="min-h-screen flex items-center justify-center bg-gray-950 p-4 relative overflow-hidden">
      <div className="w-full max-w-5xl grid grid-cols-1 md:grid-cols-2 bg-gray-900/60 backdrop-blur-xl rounded-3xl overflow-hidden shadow-2xl border border-gray-800/60">
        {/* LEFT PANEL */}
        <div className="hidden md:flex flex-col items-center justify-center relative p-10 text-white bg-gradient-to-b from-emerald-800/40 to-teal-900/40 backdrop-blur-xl">
          <div className="relative z-10 mb-6 w-full flex flex-col items-center">
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
        </div>

        {/* RIGHT PANEL */}
        <motion.div
          initial={{ opacity: 0, x: 40 }}
          animate={{ opacity: 1, x: 0 }}
          transition={{ duration: 0.5 }}
          className="p-12 bg-gray-900/60 backdrop-blur-xl"
        >
          {/* SWITCH BUTTONS */}
          <div className="flex justify-end mb-6 space-x-2">
            <button
              onClick={() => setIsLogin(true)}
              className={`px-4 py-2 rounded-xl text-sm font-semibold transition shadow-md ${
                isLogin
                  ? "bg-emerald-600 text-white shadow-emerald-700/40"
                  : "text-gray-300 hover:text-white"
              }`}
            >
              Giriş
            </button>

            <button
              onClick={() => setIsLogin(false)}
              className={`px-4 py-2 rounded-xl text-sm font-semibold transition shadow-md ${
                !isLogin
                  ? "bg-emerald-600 text-white shadow-emerald-700/40"
                  : "text-gray-300 hover:text-white"
              }`}
            >
              Kayıt Ol
            </button>
          </div>

          {/* FORM */}
          <h2 className="text-3xl font-bold text-white mb-6">
            {isLogin ? "Giriş Yap" : "Kayıt Ol"}
          </h2>

          <form className="space-y-5" onSubmit={handleSubmit}>
            {/* REGISTER FIELDS */}
            {!isLogin && (
              <>
                <div>
                  <label className="text-gray-300 text-sm">Ad Soyad</label>
                  <input
                    type="text"
                    className="w-full mt-1 p-3 bg-gray-800/70 text-white rounded-xl"
                    placeholder="Adınız Soyadınız"
                    onChange={(e) => setFullName(e.target.value)}
                  />
                </div>

                <div>
                  <label className="text-gray-300 text-sm">Kullanıcı Adı</label>
                  <input
                    type="text"
                    className="w-full mt-1 p-3 bg-gray-800/70 text-white rounded-xl"
                    placeholder="kullaniciadi"
                    onChange={(e) => setUserName(e.target.value)}
                  />
                </div>

                <div>
                  <label className="text-gray-300 text-sm">Telefon</label>
                  <input
                    type="text"
                    className="w-full mt-1 p-3 bg-gray-800/70 text-white rounded-xl"
                    placeholder="05xxxxxxxxx"
                    onChange={(e) => setPhoneNumber(e.target.value)}
                  />
                </div>
              </>
            )}

            {/* Email */}
            <div>
              <label className="text-gray-300 text-sm">Email</label>
              <input
                type="email"
                className="w-full mt-1 p-3 bg-gray-800/70 text-white rounded-xl"
                placeholder="mail@example.com"
                onChange={(e) => setEmail(e.target.value)}
              />
            </div>

            {/* Password */}
            <div>
              <label className="text-gray-300 text-sm">Şifre</label>
              <input
                type="password"
                className="w-full mt-1 p-3 bg-gray-800/70 text-white rounded-xl"
                placeholder="********"
                onChange={(e) => setPassword(e.target.value)}
              />
            </div>

            {/* Confirm Password */}
            {!isLogin && (
              <div>
                <label className="text-gray-300 text-sm">Şifre Tekrar</label>
                <input
                  type="password"
                  className="w-full mt-1 p-3 bg-gray-800/70 text-white rounded-xl"
                  placeholder="********"
                  onChange={(e) => setConfirmPassword(e.target.value)}
                />
              </div>
            )}

            {/* BUTTON */}
            <motion.button
              whileTap={{ scale: 0.97 }}
              className="w-full p-3 bg-emerald-600 hover:bg-emerald-700 transition rounded-xl text-white font-semibold mt-4"
            >
              {isLogin ? "Giriş Yap" : "Kayıt Ol"}
            </motion.button>

            {/* MESSAGE */}
            {message && (
              <p className="text-center mt-2 text-red-400 font-semibold">
                {message}
              </p>
            )}
          </form>
        </motion.div>
      </div>
    </div>
  );
}
