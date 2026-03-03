# ============================================
# PRÁCTICA #03 - CONJUNTOS Y MAPAS
# Sistema de Registro de Libros
# Autor: Jhoer Fernando Fernández Medina
# ============================================

isbn_registrados = set()
biblioteca = {}

def registrar_libro():
    print("\n--- REGISTRAR LIBRO ---")
    isbn = input("Ingrese ISBN: ")

    if isbn in isbn_registrados:
        print("❌ Error: El ISBN ya está registrado.")
        return

    titulo = input("Ingrese título: ")
    autor = input("Ingrese autor: ")
    anio = input("Ingrese año de publicación: ")

    isbn_registrados.add(isbn)
    biblioteca[isbn] = {
        "titulo": titulo,
        "autor": autor,
        "anio": anio
    }

    print("✅ Libro registrado correctamente.")


def consultar_libro():
    print("\n--- CONSULTAR LIBRO ---")
    isbn = input("Ingrese ISBN a consultar: ")

    if isbn in biblioteca:
        print("\n📚 Datos del libro:")
        print(f"Título: {biblioteca[isbn]['titulo']}")
        print(f"Autor: {biblioteca[isbn]['autor']}")
        print(f"Año: {biblioteca[isbn]['anio']}")
    else:
        print("❌ Libro no encontrado.")


def mostrar_libros():
    print("\n--- LISTA DE LIBROS REGISTRADOS ---")

    if not biblioteca:
        print("No hay libros registrados.")
        return

    for isbn, datos in biblioteca.items():
        print("\n--------------------------")
        print(f"ISBN: {isbn}")
        print(f"Título: {datos['titulo']}")
        print(f"Autor: {datos['autor']}")
        print(f"Año: {datos['anio']}")


def eliminar_libro():
    print("\n--- ELIMINAR LIBRO ---")
    isbn = input("Ingrese ISBN a eliminar: ")

    if isbn in biblioteca:
        del biblioteca[isbn]
        isbn_registrados.remove(isbn)
        print("✅ Libro eliminado correctamente.")
    else:
        print("❌ ISBN no encontrado.")


def menu():
    while True:
        print("\n===================================")
        print(" SISTEMA DE REGISTRO DE LIBROS ")
        print("===================================")
        print("1. Registrar libro")
        print("2. Consultar libro")
        print("3. Mostrar todos los libros")
        print("4. Eliminar libro")
        print("5. Salir")

        opcion = input("Seleccione una opción: ")

        if opcion == "1":
            registrar_libro()
        elif opcion == "2":
            consultar_libro()
        elif opcion == "3":
            mostrar_libros()
        elif opcion == "4":
            eliminar_libro()
        elif opcion == "5":
            print("Saliendo del sistema...")
            break
        else:
            print("❌ Opción inválida. Intente nuevamente.")


# Ejecutar programa
if __name__ == "__main__":
    menu()