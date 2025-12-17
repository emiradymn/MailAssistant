const API_URL = "http://localhost:5252/api/UserProfile/me";

export async function getMyProfile() {
    const token = localStorage.getItem("token");
    
    if(!token)
        {
            throw new Error("TOKEN_NOT_FOUND");
        }
        
        const response = await fetch(API_URL, {
            headers : {
                Authorization: `Bearer ${token}`,
            },
        });
        
        if(response.status === 401)
            {
    throw new Error("UNAUTHORIZED");
}

   if(response.status === 404)
    {
        throw new Error("NOT_FOUND");
    }
    
    if(!response.ok)
        {
            throw new Error("UNKNOWN_ERROR");
        }
        
        return response.json();
        
    }


const UPDATE_API_URL = "http://localhost:5252/api/UserProfile/update";

export async function updateMyProfile(payload) {
  const token = localStorage.getItem("token");

  if (!token) {
    throw new Error("TOKEN_NOT_FOUND");
  }

  const response = await fetch(UPDATE_API_URL, {
    method: "PUT",
    headers: {
      "Content-Type": "application/json",
      Authorization: `Bearer ${token}`
    },
    body: JSON.stringify(payload)
  });

  const result = await response.json();

  if (response.status === 401) {
    throw new Error("UNAUTHORIZED");
  }

  if (!response.ok || !result.success) {
    throw new Error(result.message || "UPDATE_FAILED");
  }

  return result;
}
