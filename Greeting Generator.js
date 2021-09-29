let Greetings = ["Hello, you have a", "Hey, you have a", "Hi, you have a"];
let Compliments = [ "cool", "fashionable", "stylish" ];
let Garments = [ "coat.", "dress.", "shirt.", "skirt.", "suit.", "swimsuit." ];
let Goodbyes = [ "ADIOS!", "BYE!", "BYE-BYE!", "FAREWELL!", "GOODBYE!" ];

let greeting = Greetings[Math.floor(Math.random() * Greetings.length)];
let compliment = Compliments[Math.floor(Math.random() * Compliments.length)];
let garment = Garments[Math.floor(Math.random() * Garments.length)];
let goodbye = Goodbyes[Math.floor(Math.random() * Goodbyes.length)];

console.log(`${greeting} ${compliment} ${garment} ${goodbye}`);