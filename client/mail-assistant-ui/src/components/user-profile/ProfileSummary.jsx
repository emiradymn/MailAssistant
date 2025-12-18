export default function ProfileSummary({ user, onEdit }) {
  return (
    <div className="relative">
      {/* ✏️ Edit */}
      <button
        onClick={onEdit}
        className="absolute top-0 right-0 text-gray-300 hover:text-emerald-400"
        title="Profili Düzenle"
      >
        ✏️
      </button>

      <div className="flex flex-col md:flex-row gap-8 items-center">
        {/* Avatar */}
        <div className="flex flex-col items-center">
          <img
            src={user.profileImageUrl ?? "https://i.pravatar.cc/150"}
            className="w-32 h-32 rounded-full border-4 border-emerald-600"
          />

          <button className="mt-3 px-4 py-2 text-sm bg-emerald-600 rounded-xl hover:bg-emerald-700">
            Fotoğrafı Değiştir
          </button>
        </div>

        {/* Text Info */}
        <div className="flex-1 space-y-2">
          <h2 className="text-3xl font-bold">{user.fullName}</h2>

          <p className="text-sm text-gray-400">@{user.userName}</p>

          <p className="text-gray-300">
            {user.currentPosition ?? "Pozisyon bilgisi yok"}
          </p>

          {/* Contact Info */}
          <div className="grid grid-cols-1 md:grid-cols-2 gap-4 mt-4">
            <InfoCard title="Email" value={user.email} />
            <InfoCard title="Telefon" value={user.phoneNumber} />
          </div>
        </div>
      </div>
    </div>
  );
}

function InfoCard({ title, value }) {
  return (
    <div className="bg-gray-800/60 p-4 rounded-xl border border-gray-700">
      <p className="text-gray-400 text-sm">{title}</p>
      <p className="font-semibold">{value ?? "-"}</p>
    </div>
  );
}
