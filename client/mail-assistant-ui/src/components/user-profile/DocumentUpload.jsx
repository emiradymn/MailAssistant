import { useState } from "react";

export default function DocumentUpload() {
  const [file, setFile] = useState(null);

  return (
    <div>
      <h3 className="text-2xl font-semibold mb-4">Doküman Yükle</h3>

      <div className="bg-gray-800/60 p-6 rounded-xl text-center">
        <input
          type="file"
          accept="application/pdf"
          className="w-full text-sm text-gray-400
                       file:mr-4 file:py-2 file:px-4
                       file:rounded-lg file:border-0
                       file:bg-emerald-500/15 file:text-emerald-400
                       hover:file:bg-emerald-500/25 transition"
          onChange={(e) => setFile(e.target.files[0])}
        />

        {file && <p className="text-emerald-400 mt-2">{file.name}</p>}
      </div>
    </div>
  );
}
