export function extractPlaceholders(template) {
  if (!template) return [];

  const regex = /{{\s*(\w+)\s*}}/g;
  const matches = [...template.matchAll(regex)];

  // sadece parametre isimleri
  const keys = matches.map(m => m[1]);

  // tekrarları kaldır
  return [...new Set(keys)];
}
