import { useState } from "react";

export default function EditProfileModal({ user, onClose, onSave }) {
  const [form, setForm] = useState({
    fullName: user.fullName ?? "",
    userName: user.userName ?? "",
    currentPosition: user.currentPosition ?? "",
    phoneNumber: user.phoneNumber ?? "",
    defaultSignature: user.defaultSignature ?? "",
  });

  const handleChange = (e) =>
    setForm({ ...form, [e.target.name]: e.target.value });

  const handleSubmit = (e) => {
    e.preventDefault();
    onSave(form);
  };

  return (
    <div className="fixed inset-0 bg-black/70 flex justify-center items-center">
      <form
        onSubmit={handleSubmit}
        className="bg-gray-900 p-6 rounded-2xl w-full max-w-lg"
      >
        <h3 className="text-xl mb-4">Profili Düzenle</h3>

        {Object.keys(form).map((key) => (
          <input
            key={key}
            name={key}
            value={form[key]}
            onChange={handleChange}
            placeholder={key}
            className="w-full mb-3 p-3 rounded bg-gray-800"
          />
        ))}

        <div className="flex justify-end gap-3">
          <button type="button" onClick={onClose}>
            İptal
          </button>
          <button type="submit" className="bg-emerald-600 px-4 py-2 rounded">
            Kaydet
          </button>
        </div>
      </form>
    </div>
  );
}
