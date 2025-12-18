import { Link } from "react-router-dom";

export default function ProfileActions() {
  return (
    <div className="grid grid-cols-1 md:grid-cols-2 gap-4 my-8">
      <Link to="/templates">
        <button className="w-full p-4 bg-blue-600 hover:bg-blue-700 rounded-2xl font-semibold">
          📁 Kendi Şablonlarım
        </button>
      </Link>

      <Link to="/sent-mails">
        <button className="w-full p-4 bg-purple-600 hover:bg-purple-700 rounded-2xl font-semibold">
          ✉️ Gönderilen Mailler
        </button>
      </Link>
    </div>
  );
}
