import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { getMyProfile, updateMyProfile } from "../services/userProfileService";

import ProfileSummary from "../components/user-profile/ProfileSummary";
import DocumentUpload from "../components/user-profile/DocumentUpload";
import ProfileActions from "../components/user-profile/ProfileActions";
import ProfileStats from "../components/user-profile/ProfileStats";
import EditProfileModal from "../components/user-profile/EditProfileModal";

export default function UserProfile() {
  const [user, setUser] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const [showEditModal, setShowEditModal] = useState(false);

  const navigate = useNavigate();

  useEffect(() => {
    getMyProfile()
      .then(setUser)
      .catch((err) => {
        if (err.message === "UNAUTHORIZED") navigate("/login");
        else setError("Profil bilgileri alınamadı");
      })
      .finally(() => setLoading(false));
  }, [navigate]);

  const handleUpdateProfile = async (form) => {
    await updateMyProfile(form);
    setUser((prev) => ({ ...prev, ...form }));
    setShowEditModal(false);
  };

  if (loading) return <div className="text-white">Yükleniyor...</div>;
  if (error) return <div className="text-red-400">{error}</div>;

  return (
    <div className="min-h-screen bg-gray-950 text-white p-6 flex justify-center">
      <div className="w-full max-w-5xl bg-gray-900/60 rounded-3xl p-8 relative">
        <ProfileSummary user={user} onEdit={() => setShowEditModal(true)} />

        <Divider />

        <DocumentUpload />

        <Divider />

        <ProfileActions />

        <ProfileStats />

        {showEditModal && (
          <EditProfileModal
            user={user}
            onClose={() => setShowEditModal(false)}
            onSave={handleUpdateProfile}
          />
        )}
      </div>
    </div>
  );
}

const Divider = () => <div className="my-8 h-px bg-gray-700/50" />;
