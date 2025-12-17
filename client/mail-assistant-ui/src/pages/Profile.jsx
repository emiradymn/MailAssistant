import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { getMyProfile } from "../services/userProfileService";
import { updateMyProfile } from "../services/userProfileService";

export default function UserProfile() {
  const [selectedFile, setSelectedFile] = useState(null);
  const [user, setUser] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  const [showEditModal, setShowEditModal] = useState(false);
  const [form, setForm] = useState({
    fullName: "",
    userName: "",
    currentPosition: "",
    phoneNumber: "",
    defaultSignature: "",
  });

  const navigate = useNavigate();

  // 🔹 PROFİLİ ÇEK
  useEffect(() => {
    getMyProfile()
      .then((data) => {
        setUser(data);
        setForm({
          fullName: data.fullName ?? "",
          userName: data.userName ?? "",
          currentPosition: data.currentPosition ?? "",
          phoneNumber: data.phoneNumber ?? "",
          defaultSignature: data.defaultSignature ?? "",
        });
      })
      .catch((err) => {
        if (
          err.message === "UNAUTHORIZED" ||
          err.message === "TOKEN_NOT_FOUND"
        ) {
          navigate("/login");
        } else {
          setError("Profil bilgileri alınamadı");
        }
      })
      .finally(() => setLoading(false));
  }, [navigate]);

  const handleChange = (e) => {
    setForm({ ...form, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    try {
      await updateMyProfile({
        fullName: form.fullName,
        userName: form.userName,
        currentPosition: form.currentPosition,
        phoneNumber: form.phoneNumber,
        defaultSignature: form.defaultSignature,
      });

      // 🟢 UI senkronu (çok önemli)
      setUser((prev) => ({
        ...prev,
        ...form,
      }));

      setShowEditModal(false);
    } catch (err) {
      if (err.message === "UNAUTHORIZED" || err.message === "TOKEN_NOT_FOUND") {
        navigate("/login");
      } else {
        alert("Profil güncellenirken hata oluştu");
      }
    }
  };

  if (loading) {
    return (
      <div className="min-h-screen bg-gray-950 flex items-center justify-center text-white">
        Profil yükleniyor...
      </div>
    );
  }

  if (error) {
    return (
      <div className="min-h-screen bg-gray-950 flex items-center justify-center text-red-400">
        {error}
      </div>
    );
  }

  return (
    <div className="min-h-screen bg-gray-950 text-white p-6 flex flex-col items-center">
      <div className="relative w-full max-w-5xl bg-gray-900/60 backdrop-blur-xl rounded-3xl p-8 shadow-2xl border border-gray-800/60">
        {/* ✏️ DÜZENLE BUTONU */}
        <button
          onClick={() => setShowEditModal(true)}
          className="absolute top-6 right-6 text-gray-300 hover:text-emerald-400"
          title="Profili Düzenle"
        >
          ✏️
        </button>

        {/* TOP */}
        <div className="flex flex-col md:flex-row items-center gap-8">
          <div className="flex flex-col items-center">
            <img
              src={user.profileImageUrl ?? "https://i.pravatar.cc/150?img=12"}
              className="w-32 h-32 rounded-full border-4 border-emerald-600"
            />
            <button className="mt-4 px-4 py-2 bg-emerald-600 rounded-xl hover:bg-emerald-700 text-sm">
              Fotoğrafı Değiştir
            </button>
          </div>

          <div className="flex-1 space-y-3">
            <h2 className="text-3xl font-bold">{user.fullName}</h2>
            <h4 className="text-sm font-normal text-gray-300">
              @{user.userName}
            </h4>

            <p className="text-gray-300">
              {user.currentPosition ?? "Pozisyon bilgisi yok"}
            </p>

            <div className="grid grid-cols-1 md:grid-cols-2 gap-4 mt-4">
              <div className="bg-gray-800/60 p-4 rounded-xl border border-gray-700">
                <p className="text-gray-400 text-sm">Email</p>
                <p className="font-semibold">{user.email ?? "Email yok"}</p>
              </div>

              <div className="bg-gray-800/60 p-4 rounded-xl border border-gray-700">
                <p className="text-gray-400 text-sm">Telefon</p>
                <p className="font-semibold">
                  {user.phoneNumber ?? "Telefon yok"}
                </p>
              </div>
            </div>
          </div>
        </div>
        {/* DIVIDER */}
        <div className="my-8 h-px bg-gray-700/50" />

        {/* DOCUMENT UPLOAD */}
        <div className="space-y-4">
          <h3 className="text-2xl font-semibold">Doküman Yükle (.pdf)</h3>
          <div className="bg-gray-800/60 p-6 rounded-2xl border border-gray-700 flex flex-col items-center justify-center">
            <input
              type="file"
              accept="application/pdf"
              className="text-gray-300 mb-3"
              onChange={(e) => setSelectedFile(e.target.files[0])}
            />

            {selectedFile && (
              <p className="text-emerald-400 text-sm">
                {selectedFile.name} seçildi
              </p>
            )}

            <button className="mt-4 px-5 py-2 bg-emerald-600 rounded-xl hover:bg-emerald-700 font-semibold">
              Yükle
            </button>
          </div>
        </div>

        {/* DIVIDER */}
        <div className="my-8 h-px bg-gray-700/50" />

        {/* ACTION BUTTONS */}
        <div className="grid grid-cols-1 md:grid-cols-2 gap-4 mb-10">
          <a href="/templates" className="w-full">
            <button className="w-full p-4 bg-blue-600 hover:bg-blue-700 rounded-2xl font-semibold shadow-lg">
              📁 Kendi Şablonlarım
            </button>
          </a>

          <a href="/sent-mails" className="w-full">
            <button className="w-full p-4 bg-purple-600 hover:bg-purple-700 rounded-2xl font-semibold shadow-lg">
              ✉️ Gönderilen Mailler
            </button>
          </a>
        </div>

        {/* STATS (ŞİMDİLİK STATİK) */}
        <div>
          <h3 className="text-2xl font-semibold mb-4">Mail İstatistikleri</h3>

          <div className="grid grid-cols-1 md:grid-cols-3 gap-6">
            <div className="bg-gray-800/60 p-6 rounded-xl border border-gray-700 text-center">
              <p className="text-gray-400 text-sm">Toplam Gönderilen Mail</p>
              <p className="text-3xl font-bold mt-2">128</p>
            </div>

            <div className="bg-gray-800/60 p-6 rounded-xl border border-gray-700 text-center">
              <p className="text-gray-400 text-sm">Kullanılan Şablonlar</p>
              <p className="text-3xl font-bold mt-2">12</p>
            </div>

            <div className="bg-gray-800/60 p-6 rounded-xl border border-gray-700 text-center">
              <p className="text-gray-400 text-sm">Son 30 Gün Mail</p>
              <p className="text-3xl font-bold mt-2">34</p>
            </div>
          </div>
        </div>
      </div>

      {/* 🔥 MODAL */}
      {showEditModal && (
        <div className="fixed inset-0 bg-black/70 flex items-center justify-center z-50">
          <div className="w-full max-w-lg bg-gray-900 rounded-2xl p-6 border border-gray-700">
            <h3 className="text-2xl font-semibold mb-4">Profili Düzenle</h3>

            <form onSubmit={handleSubmit} className="space-y-4">
              <input
                name="fullName"
                value={form.fullName}
                onChange={handleChange}
                placeholder="Ad Soyad"
                className="w-full p-3 rounded-xl bg-gray-800 border border-gray-700"
              />
              <input
                name="userName"
                value={form.userName}
                onChange={handleChange}
                placeholder="Kullanıcı Adı"
                className="w-full p-3 rounded-xl bg-gray-800 border border-gray-700"
              />

              <input
                name="currentPosition"
                value={form.currentPosition}
                onChange={handleChange}
                placeholder="Pozisyon"
                className="w-full p-3 rounded-xl bg-gray-800 border border-gray-700"
              />

              <input
                name="phoneNumber"
                value={form.phoneNumber}
                onChange={handleChange}
                placeholder="Telefon"
                className="w-full p-3 rounded-xl bg-gray-800 border border-gray-700"
              />

              <textarea
                name="defaultSignature"
                value={form.defaultSignature}
                onChange={handleChange}
                placeholder="Varsayılan imza"
                rows={3}
                className="w-full p-3 rounded-xl bg-gray-800 border border-gray-700"
              />

              <div className="flex justify-end gap-3 pt-2">
                <button
                  type="button"
                  onClick={() => setShowEditModal(false)}
                  className="px-4 py-2 rounded-xl bg-gray-700 hover:bg-gray-600"
                >
                  İptal
                </button>

                <button
                  type="submit"
                  className="px-4 py-2 rounded-xl bg-emerald-600 hover:bg-emerald-700"
                >
                  Kaydet
                </button>
              </div>
            </form>
          </div>
        </div>
      )}
    </div>
  );
}
