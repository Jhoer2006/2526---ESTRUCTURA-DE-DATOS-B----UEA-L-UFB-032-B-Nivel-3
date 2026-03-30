# =========================
# GRAFO (ciudades)
# =========================
grafo = {}

def agregar_ciudad():
    ciudad = input("Ingrese el nombre de la ciudad: ")
    if ciudad not in grafo:
        grafo[ciudad] = []
        print("Ciudad agregada correctamente.")
    else:
        print("La ciudad ya existe.")

def conectar_ciudades():
    c1 = input("Ingrese la primera ciudad: ")
    c2 = input("Ingrese la segunda ciudad: ")

    if c1 in grafo and c2 in grafo:
        grafo[c1].append(c2)
        grafo[c2].append(c1)
        print("Ciudades conectadas correctamente.")
    else:
        print("Una o ambas ciudades no existen.")

def mostrar_grafo():
    print("\n--- GRAFO DE CIUDADES ---")
    for ciudad in grafo:
        print(ciudad, "->", grafo[ciudad])


# =========================
# ÁRBOL (estructura jerárquica)
# =========================
class Nodo:
    def __init__(self, valor):
        self.valor = valor
        self.hijos = []

def mostrar_arbol(nodo, nivel=0):
    print(" " * nivel * 2 + nodo.valor)
    for hijo in nodo.hijos:
        mostrar_arbol(hijo, nivel + 1)


# Crear árbol de ejemplo
raiz = Nodo("Empresa")
gerencia = Nodo("Gerencia")
produccion = Nodo("Producción")
ventas = Nodo("Ventas")

raiz.hijos.append(gerencia)
raiz.hijos.append(produccion)
gerencia.hijos.append(ventas)


# =========================
# MENÚ PRINCIPAL
# =========================
def menu():
    while True:
        print("\n====== MENÚ ======")
        print("1. Agregar ciudad")
        print("2. Conectar ciudades")
        print("3. Mostrar grafo")
        print("4. Mostrar árbol")
        print("5. Salir")

        opcion = input("Seleccione una opción: ")

        if opcion == "1":
            agregar_ciudad()
        elif opcion == "2":
            conectar_ciudades()
        elif opcion == "3":
            mostrar_grafo()
        elif opcion == "4":
            print("\n--- ÁRBOL ---")
            mostrar_arbol(raiz)
        elif opcion == "5":
            print("Saliendo del sistema...")
            break
        else:
            print("Opción inválida.")


# Ejecutar programa
menu()