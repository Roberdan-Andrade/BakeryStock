//Botão add_user

const btn_add_user = document.querySelector(".botao-add-user");

btn_add_user.addEventListener("click", function () {
    const form_add_user = document.querySelector(".formulario-add-user");
    const form_delete_user = document.querySelector(".formulario-delete-user");

    form_delete_user.classList.remove("display-block");
    form_delete_user.classList.add("display-none");

    form_add_user.classList.remove("display-none");
    form_add_user.classList.add("display-block");
});

//Botão delete_user

const btn_delete_user = document.querySelector(".botao-delete-user");

btn_delete_user.addEventListener("click", function () {
    const form_add_user = document.querySelector(".formulario-add-user");
    const form_delete_user = document.querySelector(".formulario-delete-user");

    form_add_user.classList.remove("display-block");
    form_add_user.classList.add("display-none");

    form_delete_user.classList.remove("display-none");
    form_delete_user.classList.add("display-block");
})


//Botão add_table

const btn_add_table = document.querySelector(".botao-add-table");

btn_add_table.addEventListener("click", function () {
    const form_add_table = document.querySelector(".formulario-add-table");
    const form_delete_table = document.querySelector(".formulario-delete-table");

    form_delete_table.classList.remove("display-block");
    form_delete_table.classList.add("display-none");

    form_add_table.classList.remove("display-none");
    form_add_table.classList.add("display-block");
})

//Botão delete_table

const btn_delete_table = document.querySelector(".botao-delete-table");

btn_delete_table.addEventListener("click", function () {
    const form_add_table = document.querySelector(".formulario-add-table");
    const form_delete_table = document.querySelector(".formulario-delete-table");

    form_add_table.classList.remove("display-block");
    form_add_table.classList.add("display-none");

    form_delete_table.classList.remove("display-none");
    form_delete_table.classList.add("display-block");
})


//Botoes fechar

const btn_fechar_add_user = document.querySelector(".fechar-add-user");

btn_fechar_add_user.addEventListener("click", function () {
    const form_add_user = document.querySelector(".formulario-add-user");
    const form_delete_user = document.querySelector(".formulario-delete-user");

    form_delete_user.classList.remove("display-block");
    form_delete_user.classList.add("display-none");

    form_add_user.classList.remove("display-block");
    form_add_user.classList.add("display-none");
})


const btn_fechar_delete_user = document.querySelector(".fechar-delete-user");

btn_fechar_delete_user.addEventListener("click", function () {
    const form_add_user = document.querySelector(".formulario-add-user");
    const form_delete_user = document.querySelector(".formulario-delete-user");

    form_delete_user.classList.remove("display-block");
    form_delete_user.classList.add("display-none");

    form_add_user.classList.remove("display-block");
    form_add_user.classList.add("display-none");
})

const btn_fechar_add_table = document.querySelector(".fechar-add-table");

btn_fechar_add_table.addEventListener("click", function () {
    const form_add_table = document.querySelector(".formulario-add-table");
    const form_delete_table = document.querySelector(".formulario-delete-table");

    form_add_table.classList.remove("display-block");
    form_add_table.classList.add("display-none");

    form_delete_table.classList.remove("display-block");
    form_delete_table.classList.add("display-none");
})

const btn_fechar_delete_table = document.querySelector(".fechar-delete-table");

btn_fechar_delete_table.addEventListener("click", function () {
    const form_add_table = document.querySelector(".formulario-add-table");
    const form_delete_table = document.querySelector(".formulario-delete-table");

    form_add_table.classList.remove("display-block");
    form_add_table.classList.add("display-none");

    form_delete_table.classList.remove("display-block");
    form_delete_table.classList.add("display-none");
})
