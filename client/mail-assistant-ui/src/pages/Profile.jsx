import { useState } from "react";

export default function UserProfile() {
  const [selectedFile, setSelectedFile] = useState(null);

  return (
    <div className="min-h-screen bg-gray-950 text-white p-6 flex flex-col items-center">
      {/* PROFILE CARD */}
      <div className="w-full max-w-5xl bg-gray-900/60 backdrop-blur-xl rounded-3xl p-8 shadow-2xl border border-gray-800/60">
        {/* TOP SECTION - USER INFO */}
        <div className="flex flex-col md:flex-row items-center md:items-start gap-8">
          {/* Avatar */}
          <div className="flex flex-col items-center">
            <img
              src="https://i.pravatar.cc/150?img=12"
              className="w-32 h-32 rounded-full border-4 border-emerald-600 shadow-xl"
            />
            <button className="mt-4 px-4 py-2 bg-emerald-600 rounded-xl hover:bg-emerald-700 text-sm font-semibold">
              Fotoğrafı Değiştir
            </button>
          </div>

          {/* Info */}
          <div className="flex-1 space-y-3">
            <h2 className="text-3xl font-bold">Emir Adıyaman</h2>
            <p className="text-gray-300">
              Backend Developer • Mail Assistant Kullanıcısı
            </p>

            <div className="grid grid-cols-1 md:grid-cols-2 gap-4 mt-4">
              <div className="bg-gray-800/60 p-4 rounded-xl border border-gray-700">
                <p className="text-gray-400 text-sm">Email</p>
                <p className="font-semibold">emir@example.com</p>
              </div>

              <div className="bg-gray-800/60 p-4 rounded-xl border border-gray-700">
                <p className="text-gray-400 text-sm">Telefon</p>
                <p className="font-semibold">05xx xxx xx xx</p>
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

        {/* STATS */}
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
    </div>
  );
}
