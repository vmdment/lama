import { useEffect, useState } from "react"

export const ListMembers = () => {
    const [members, setMembers] = useState([]);
    useEffect(() => {
        (async () => {
            const headers = new Headers({
                accept: 'application/json',
                'Content-Type': 'application/json'
            });
            const data = await (await fetch(`https://lama-baa2dphgfmdphfa0.canadacentral-01.azurewebsites.net/api/Member`, { headers })).json();
            console.log({ data });
            setMembers(data);
        })()
    }, [])
    return (
        <div className="flex flex-col gap-4">
            <table className="overflow-x-scroll">
                <thead>
                    <tr className="border">
                        <th className="text-nowrap border p-2">Id</th>
                        <th className="text-nowrap border p-2">Nombre</th>
                        <th className="text-nowrap border p-2">Apellido</th>
                        <th className="text-nowrap border p-2">Celular</th>
                        <th className="text-nowrap border p-2">Correo Electronico</th>
                        <th className="text-nowrap border p-2">Fecha de Ingreso</th>
                        <th className="text-nowrap border p-2">Direccion</th>
                        <th className="text-nowrap border p-2">Miembro</th>
                        <th className="text-nowrap border p-2">Cargo</th>
                        <th className="text-nowrap border p-2">Rango</th>
                        <th className="text-nowrap border p-2">Estatus</th>
                        <th className="text-nowrap border p-2">Fecha de Nacimiento</th>
                        <th className="text-nowrap border p-2">Cedula</th>
                        <th className="text-nowrap border p-2">RH</th>
                        <th className="text-nowrap border p-2">EPS</th>
                        <th className="text-nowrap border p-2">Padrino</th>
                        <th className="text-nowrap border p-2">Foto</th>
                        <th className="text-nowrap border p-2">Contacto de emergencia</th>
                        <th className="text-nowrap border p-2">Ciudad</th>
                        <th className="text-nowrap border p-2">Moto</th>
                        <th className="text-nowrap border p-2">Año Modelo</th>
                        <th className="text-nowrap border p-2">Marca</th>
                        <th className="text-nowrap border p-2">Cilindraje CC</th>
                        <th className="text-nowrap border p-2">Placa matricula</th>
                        <th className="text-nowrap border p-2">Fecha Expedicion SOAT</th>
                        <th className="text-nowrap border p-2">Fecha de expedicion licencia conduccion</th>
                    </tr>
                </thead>
                <tbody>
                    {members.map(({ id, nombre, apellido, celular, correoElectronico, fechaIngreso, direccion, miembro, cargo, rango, estatus, fechaNacimiento, cedula, rh, eps, padrino, foto, contactoEmergencia, ciudad, moto, anoModelo, marca, cilindrajeCC, placaMatricula, fechaExpedicionSOAT, fechaExpedicionLicenciaConduccion }) => (
                        <tr className="border">
                            <td className='border p-2'>{id}</td>
                            <td className='border p-2'>{nombre}</td>
                            <td className='border p-2'>{apellido}</td>
                            <td className='border p-2'>{celular}</td>
                            <td className='border p-2'>{correoElectronico}</td>
                            <td className='border p-2'>{fechaIngreso}</td>
                            <td className='border p-2'>{direccion}</td>
                            <td className='border p-2'>{miembro}</td>
                            <td className='border p-2'>{cargo}</td>
                            <td className='border p-2'>{rango}</td>
                            <td className='border p-2'>{estatus}</td>
                            <td className='border p-2'>{fechaNacimiento}</td>
                            <td className='border p-2'>{cedula}</td>
                            <td className='border p-2'>{rh}</td>
                            <td className='border p-2'>{eps}</td>
                            <td className='border p-2'>{padrino}</td>
                            <td className='border p-2'>{foto}</td>
                            <td className='border p-2'>{contactoEmergencia}</td>
                            <td className='border p-2'>{ciudad}</td>
                            <td className='border p-2'>{moto}</td>
                            <td className='border p-2'>{anoModelo}</td>
                            <td className='border p-2'>{marca}</td>
                            <td className='border p-2'>{cilindrajeCC}</td>
                            <td className='border p-2'>{placaMatricula}</td>
                            <td className='border p-2'>{fechaExpedicionSOAT}</td>
                            <td className='border p-2'>{fechaExpedicionLicenciaConduccion}</td>

                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    )
}