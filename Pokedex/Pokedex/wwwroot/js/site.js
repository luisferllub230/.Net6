//for change the form action in pokemon
let id = document.getElementById("IDpokemonSave");
let saveFormPokemon = document.getElementById("saveForm");
let h4Pokemon = document.getElementById("h4Pokemon")

if (id.value === "0") {
    saveFormPokemon.action = "/Pokemons/CreatePokemons";
    h4Pokemon.innerText = "Create mode";
} else {
    saveFormPokemon.action = "/Pokemons/EditPokemons";
    h4Pokemon.innerText = "Edit mode";
}
