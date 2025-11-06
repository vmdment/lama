import { NavLink, Outlet, type NavLinkRenderProps } from "react-router"

export const PublicLayout = () => {
    const isActive = ({ isActive }: NavLinkRenderProps) => { return `hover:underline ${isActive ? 'font-bold text-white' : ''}`; }
    return (
        <div>
            <nav className="bg-blue-600 w-full h-16 fixed top-0 left-0 flex justify-between items-center p-4">
                <NavLink to={'/'} className={isActive}>Inicio</NavLink>
                <ul className="flex gap-3">
                    <li>
                        <NavLink className={isActive} to={'/list-member'}>Lista de miembros</NavLink>
                    </li>
                    <li>
                        <NavLink className={isActive} to={'/update-member'}>Actualizar Miembro</NavLink>
                    </li>
                </ul>
            </nav>
            <div className="mt-20 p-4">
                <Outlet />
            </div>
        </div>
    )
}