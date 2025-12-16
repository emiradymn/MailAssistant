import { useEffect, useState } from "react";
import { getUserProfile } from "../services/userProfileService";

export default function useUserProfile() {
  const [profile, setProfile] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState("");

  useEffect(() => {
    let isMounted = true;

    const fetchProfile = async () => {
      try {
        const data = await getUserProfile();
        if (isMounted) setProfile(data);
      } catch {
        if (isMounted) setError("Profil bilgileri alınamadı");
      } finally {
        if (isMounted) setLoading(false);
      }
    };

    fetchProfile();
    return () => (isMounted = false);
  }, []);

  return { profile, loading, error };
}
