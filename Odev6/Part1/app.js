const {kopek} = require('./kopek.js');
const {kopegiTemizle,kopekBakimSaati}=require('./kopekBakimUtility.js');
console.log(`Kopek adi: ${kopek.name}`);
console.log(`Kopek boyu: ${kopek.boyu}`);
kopegiTemizle();
console.log(`Kopek ilgi saati: ${kopek.kilo*kopekBakimSaati}`);