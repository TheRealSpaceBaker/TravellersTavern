(function () {
    function closeAllDropdowns(except) {
        document.querySelectorAll("details.dropdown[open]").forEach((d) => {
            if (except && except === d) return;
            d.removeAttribute("open");
        });
    }

    document.addEventListener("click", (e) => {
        const clickedDropdown = e.target.closest("details.dropdown");

        // Klik in een dropdown: laat die open, maar sluit andere dropdowns
        if (clickedDropdown) {
            closeAllDropdowns(clickedDropdown);

            // Als je op een link in het dropdown-menu klikt, sluit ook die dropdown
            if (e.target.closest("a.dropdown-link")) {
                clickedDropdown.removeAttribute("open");
            }

            return;
        }

        // Klik buiten: sluit alles
        closeAllDropdowns();
    });

    document.addEventListener("keydown", (e) => {
        if (e.key === "Escape") closeAllDropdowns();
    });
})();
