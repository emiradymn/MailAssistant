export default function AuthSwitcher({ isLogin, setIsLogin }) {
  return (
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
  );
}
