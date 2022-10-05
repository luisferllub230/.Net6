//for change the form action in pokemon
let id = document.getElementsByClassName("IDSave");


let saveFormPokemon = document.getElementsByClassName("saveForm");
let saveFormPokemonType = document.getElementsByClassName("saveTypeForm");


if (id.value === "0") {
    saveFormPokemon.action = "/Pokemons/CreatePokemons";
    saveFormPokemonType.action ="/Pokemons/CreatePokemonsTypes"
} else {
    saveFormPokemon.action = "/Pokemons/EditPokemons";
    saveFormPokemonType.action = "/Pokemons/EditPokemonsTypes"
}
