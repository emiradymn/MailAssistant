export default function ProfileStats() {
  return (
    <div>
      <h3 className="text-2xl font-semibold mb-4">Mail İstatistikleri</h3>

      <div className="grid grid-cols-1 md:grid-cols-3 gap-6">
        <StatCard title="Toplam Gönderilen Mail" value="128" />
        <StatCard title="Kullanılan Şablonlar" value="12" />
        <StatCard title="Son 30 Gün Mail" value="34" />
      </div>
    </div>
  );
}

function StatCard({ title, value }) {
  return (
    <div className="bg-gray-800/60 p-6 rounded-xl border border-gray-700 text-center">
      <p className="text-gray-400 text-sm">{title}</p>
      <p className="text-3xl font-bold mt-2">{value}</p>
    </div>
  );
}
