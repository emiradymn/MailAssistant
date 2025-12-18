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
          onChange={(e) => setFile(e.target.files[0])}
        />

        {file && <p className="text-emerald-400 mt-2">{file.name}</p>}
      </div>
    </div>
  );
}
