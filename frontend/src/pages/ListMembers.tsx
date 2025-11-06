import { useEffect, useState } from "react"

export const ListMembers = () => {
    const [members, setMembers] = useState([]);
    useEffect(() => {
        (async () => {
            const data = await (await fetch(`https://lama-baa2dphgfmdphfa0.canadacentral-01.azurewebsites.net/api/Member`, { mode: 'no-cors' })).json();
            setMembers(data);
        })()
    }, [])
    return (
        <div className="flex flex-col gap-4">
            <table className="overflow-x-scroll">
                <thead>
                    <tr className="flex gap-4">
                        <th className="text-nowrap">Id</th>
                        <th className="text-nowrap">Nombre</th>
                        <th className="text-nowrap">Apellido</th>
                        <th className="text-nowrap">Celular</th>
                        <th className="text-nowrap">Correo Electronico</th>
                        <th className="text-nowrap">Fecha de Ingreso</th>
                        <th className="text-nowrap">Direccion</th>
                        <th className="text-nowrap">Miembro</th>
                        <th className="text-nowrap">Cargo</th>
                        <th className="text-nowrap">Rango</th>
                        <th className="text-nowrap">Estatus</th>
                        <th className="text-nowrap">Fecha de Nacimiento</th>
                        <th className="text-nowrap">Cedula</th>
                        <th className="text-nowrap">RH</th>
                        <th className="text-nowrap">EPS</th>
                        <th className="text-nowrap">Padrino</th>
                        <th className="text-nowrap">Foto</th>
                        <th className="text-nowrap">Contacto de emergencia</th>
                        <th className="text-nowrap">Ciudad</th>
                        <th className="text-nowrap">Moto</th>
                        <th className="text-nowrap">Año Modelo</th>
                        <th className="text-nowrap">Marca</th>
                        <th className="text-nowrap">Cilindraje CC</th>
                        <th className="text-nowrap">Placa matricula</th>
                        <th className="text-nowrap">Fecha Expedicion SOAT</th>
                        <th className="text-nowrap">Fecha de expedicion licencia conduccion</th>
                    </tr>
                </thead>
                <tbody>
                    {members.map(({ id, nombre, apellido, celular, correoElectronico, fechaIngreso, direccion, miembro, cargo, rango, estatus, fechaNacimiento, cedula, rh, eps, padrino, foto, contactoEmergencia, ciudad, moto, anoModelo, marca, cilindrajeCC, placaMatricula, fechaExpedicionSOAT, fechaExpedicionLicenciaConduccion }) => (
                        <tr>
                            <td>{id}</td>
                            <td>{nombre}</td>
                            <td>{apellido}</td>
                            <td>{celular}</td>
                            <td>{correoElectronico}</td>
                            <td>{fechaIngreso}</td>
                            <td>{direccion}</td>
                            <td>{miembro}</td>
                            <td>{cargo}</td>
                            <td>{rango}</td>
                            <td>{estatus}</td>
                            <td>{fechaNacimiento}</td>
                            <td>{cedula}</td>
                            <td>{rh}</td>
                            <td>{eps}</td>
                            <td>{padrino}</td>
                            <td>{foto}</td>
                            <td>{contactoEmergencia}</td>
                            <td>{ciudad}</td>
                            <td>{moto}</td>
                            <td>{anoModelo}</td>
                            <td>{marca}</td>
                            <td>{cilindrajeCC}</td>
                            <td>{placaMatricula}</td>
                            <td>{fechaExpedicionSOAT}</td>
                            <td>{fechaExpedicionLicenciaConduccion}</td>

                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    )
}