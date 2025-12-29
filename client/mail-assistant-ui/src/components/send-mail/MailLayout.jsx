export default function MailLayout({ children }) {
  return (
    <div className="bg-gray-950 text-gray-200 min-h-screen flex items-center justify-center">
      <div
        className="w-full max-w-7xl h-[85vh] bg-gray-900/70 border border-gray-800
                   rounded-3xl overflow-hidden grid grid-cols-2"
      >
        {children}
      </div>
    </div>
  );
}
