import { useState } from "react";
import { replace, useNavigate } from "react-router-dom";

export default function LoginForm() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [message, setMessage] = useState("");

  const navigate = useNavigate();

  const API_URL = "http://localhost:5252/api/auth/login";

  const handleLogin = async (e) => {
    e.preventDefault();
    setMessage("");

    const payload = {
      userNameOrEmail: email,
      password,
    };

    try {
      const res = await fetch(API_URL, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(payload),
      });

      const data = await res.json();

      if (!res.ok) {
        setMessage("E-posta veya şifre hatalı!");
        return;
      }

      // TOKEN KAYDET
      localStorage.setItem("token", data.token);

      setMessage("Giriş başarılı! 🎉");

      // 1 saniye sonra profile yönlendir
      setTimeout(() => {
        navigate("/profile", { replace: true });
      }, 800);
    } catch (err) {
      setMessage("Sunucuya bağlanılamıyor!");
    }
  };

  return (
    <form className="space-y-5" onSubmit={handleLogin}>
      <div>
        <label className="text-gray-300 text-sm">Email</label>
        <input
          type="email"
          className="w-full mt-1 p-3 bg-gray-800/70 text-white rounded-xl"
          placeholder="mail@example.com"
          onChange={(e) => setEmail(e.target.value)}
        />
      </div>

      <div>
        <label className="text-gray-300 text-sm">Şifre</label>
        <input
          type="password"
          className="w-full mt-1 p-3 bg-gray-800/70 text-white rounded-xl"
          placeholder="********"
          onChange={(e) => setPassword(e.target.value)}
        />
      </div>

      <button className="w-full p-3 bg-emerald-600 hover:bg-emerald-700 transition rounded-xl text-white font-semibold mt-4">
        Giriş Yap
      </button>

      {message && (
        <p className="text-center text-emerald-400 mt-2">{message}</p>
      )}
    </form>
  );
}
