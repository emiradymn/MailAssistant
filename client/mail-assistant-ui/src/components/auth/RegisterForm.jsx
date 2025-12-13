import { useState } from "react";

export default function RegisterForm() {
  const [fullName, setFullName] = useState("");
  const [userName, setUserName] = useState("");
  const [phoneNumber, setPhoneNumber] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const [message, setMessage] = useState("");

  const API_URL = "http://localhost:5252/api/auth/register";

  const handleRegister = async (e) => {
    e.preventDefault();
    setMessage("");

    if (password !== confirmPassword) {
      setMessage("Şifreler eşleşmiyor!");
      return;
    }

    const payload = {
      fullName,
      userName,
      email,
      phoneNumber,
      password,
      confirmPassword,
    };

    try {
      const res = await fetch(API_URL, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(payload),
      });

      const data = await res.json();

      if (!res.ok) {
        if (data.errors) {
          setMessage(data.errors.join(" | "));
          return;
        }
        setMessage("Kayıt başarısız!");
        return;
      }

      setMessage("Kayıt başarılı! ✔");
    } catch (err) {
      setMessage("Sunucuya bağlanılamıyor!");
    }
  };

  return (
    <form className="space-y-5" onSubmit={handleRegister}>
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

      <div>
        <label className="text-gray-300 text-sm">Şifre Tekrar</label>
        <input
          type="password"
          className="w-full mt-1 p-3 bg-gray-800/70 text-white rounded-xl"
          placeholder="********"
          onChange={(e) => setConfirmPassword(e.target.value)}
        />
      </div>

      <button className="w-full p-3 bg-emerald-600 hover:bg-emerald-700 transition rounded-xl text-white font-semibold mt-4">
        Kayıt Ol
      </button>

      {message && <p className="text-red-400 text-center">{message}</p>}
    </form>
  );
}
