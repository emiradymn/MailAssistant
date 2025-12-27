const API_URL = "http://localhost:5252/api/email-templates";

export async function getEmailTemplates(categoryId) {
  const url = categoryId
    ? `${API_URL}?categoryId=${categoryId}`
    : API_URL;

  const res = await fetch(url);

  if (!res.ok) {
    throw new Error("Templates alınamadı");
  }

  return await res.json();
}
