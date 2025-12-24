import axios from "axios";

const API_URL = "http://localhost:5252/api/email-template-categories";

export const getEmailTemplateCategories = async () => {
  const response = await axios.get(API_URL);
  return response.data;
};