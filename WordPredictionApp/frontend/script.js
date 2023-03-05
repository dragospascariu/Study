let word = "";
function retrieveWords(input) {
  wordBuilder(input);
  initializeLists();
  performApi();
}

function performApi() {
  if (word === "") {
    return;
  }
  let locale = document.getElementById("language").value;
  console.log(locale);
  const uri = `https://localhost:7780/Api/Backend?text=${word}&locale=${locale}`;
  const fetchAPI = async () => {
    const response = await fetch(uri);
    const jsonResponse = await response.json();
    makeUL(jsonResponse[0]);
    makeUL(jsonResponse[1]);
    document.getElementById("list1").appendChild(makeUL(jsonResponse[0]));
    document.getElementById("list2").appendChild(makeUL(jsonResponse[1]));
  };
  fetchAPI();
}

function initializeLists() {
  let l1 = document.getElementById("list1");
  while (l1.firstChild) {
    l1.removeChild(l1.firstChild);
  }
  let l2 = document.getElementById("list2");
  while (l2.firstChild) {
    l2.removeChild(l2.firstChild);
  }
}

function wordBuilder(event) {
  if (event === " ") {
    word = "";
    console.log(word);
    return;
  }
  word = word + event;
  console.log(word);
}

function makeUL(array) {
  const list = document.createElement("ul");
  for (let i = 0; i < array.length; i++) {
    let item = document.createElement("li");

    item.appendChild(document.createTextNode(array[i]));

    list.appendChild(item);
  }
  return list;
}
