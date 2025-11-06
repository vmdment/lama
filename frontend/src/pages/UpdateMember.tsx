import type { FormEvent, MouseEvent } from "react"
import { InputField } from "../components/InputField";
import { InputList } from "../components/InputList";
import { useForm } from "../hooks/useForm";
const initialForm = {
    id: '',
    nombre: '',
    apellido: '',
    celular: '',
    correoElectronico: '',
    fechaIngreso: '',
    direccion: '',
    miembro: 0,
    cargo: '',
    rango: '',
    estatus: '',
    fechaNacimiento: '',
    cedula: '',
    rh: '',
    eps: '',
    padrino: '',
    foto: '',
    contactoEmergencia: '',
    ciudad: '',
    moto: '',
    anoModelo: '',
    marca: '',
    cilindrajeCC: '',
    placaMatricula: '',
    fechaExpedicionSOAT: '',
    fechaExpedicionLicenciaConduccion: ''
}
export const UpdateMember = () => {
    const rhTypes = [{ text: 'A+', value: 'A+' }, { text: 'A-', value: 'A-' }, { text: 'B', value: 'B' }, { text: 'B-', value: 'B-' }, { text: 'AB+', value: 'AB+' }, { text: 'O', value: 'O' }];
    const { form, handleChange } = useForm(initialForm);
    const {
        id,
        nombre,
        apellido,
        celular,
        correoElectronico,
        fechaIngreso,
        direccion,
        miembro,
        cargo,
        rango,
        estatus,
        fechaNacimiento,
        cedula,
        rh,
        eps,
        padrino,
        foto,
        contactoEmergencia,
        ciudad,
        moto,
        anoModelo,
        marca,
        cilindrajeCC,
        placaMatricula,
        fechaExpedicionSOAT,
        fechaExpedicionLicenciaConduccion
    } = form;
    const handleSubmit = async (e: FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        const data = await (await fetch(`https://lama-baa2dphgfmdphfa0.canadacentral-01.azurewebsites.net/api/Member`, { mode: 'cors', method: 'POST', body: JSON.stringify({ ...form, foto: '' }) })).json();
        console.log({ data });
    }
    const handleClickUpdate = (e: MouseEvent<HTMLButtonElement>) => {
        e.preventDefault();
    }
    return (
        <div>
            <form onSubmit={handleSubmit} className="flex flex-col gap-3">
                <InputField label="Id" value={id} name="id" placeholder="Ingrese el id" handleChange={handleChange} />
                <div className="flex gap-4 ">
                    <InputField label="Nombre" value={nombre} name="nombre" placeholder="Ingrese su nombre" handleChange={handleChange} />
                    <InputField label="Apellido" value={apellido} name="apellido" placeholder="Ingrese su apellido" handleChange={handleChange} />
                    <InputField label="Celular" value={celular} name="celular" placeholder="Ingrese su celular" handleChange={handleChange} />
                </div>
                <div className="flex gap-4 ">
                    <InputField label="Correo Electronico" value={correoElectronico} name="correoElectronico" placeholder="Ingrese su correo electronico" handleChange={handleChange} />
                    <InputField label="Fecha de Ingreso" value={fechaIngreso} type='date' name="fechaIngreso" placeholder="Ingrese la fecha ingreso" handleChange={handleChange} />
                    <InputField label="Direccion" value={direccion} name="direccion" placeholder="Ingrese su direccion" handleChange={handleChange} />
                </div>
                <div className="flex gap-4 ">
                    <InputField label="Miembro" value={miembro} name="miembro" placeholder="Ingrese su miembro number" handleChange={handleChange} />
                    <InputField label="Cargo" value={cargo} name="cargo" placeholder="Ingrese su cargo" handleChange={handleChange} />
                    <InputField label="Rango" value={rango} name="rango" placeholder="Ingrese su rango" handleChange={handleChange} />
                </div>

                <div className="flex gap-4 ">
                    <InputField label="Estatus" value={estatus} name="estatus" placeholder="Ingrese su estatus" handleChange={handleChange} />
                    <InputField label="Fecha de Nacimiento" value={fechaNacimiento} name="fechaNacimiento" type='date' placeholder="Ingrese su nombre" handleChange={handleChange} />
                    <InputField label="Cedula" value={cedula} name="cedula" placeholder="Ingrese su cedula" handleChange={handleChange} />
                </div>
                <div className="flex gap-4">
                    <InputList label='RH' value={rh} name="rh" handleChange={handleChange} options={rhTypes} />
                    <InputField label="EPS" value={eps} name="eps" placeholder="Ingrese su eps" handleChange={handleChange} />
                    <InputField label="Padrino" value={padrino} name="padrino" type='text' placeholder="Ingrese su padrino" handleChange={handleChange} />
                </div>
                <div className="flex gap-4 ">
                    <InputField label="Foto" value={foto} name="foto" placeholder="Ingrese su foto" type='text' handleChange={handleChange} />
                    <InputField label="Contacto de emergencia" value={contactoEmergencia} name="contactoEmergencia" type='text' placeholder="Ingrese su contacto de emergencia" handleChange={handleChange} />
                    <InputField label="Ciudad" value={ciudad} name="ciudad" placeholder="Ingrese su ciudad de residencia" type='text' handleChange={handleChange} />
                </div>
                <div className="flex gap-4 ">
                    <InputField label="Moto" value={moto} name="moto" type='text' placeholder="Ingrese su moto" handleChange={handleChange} />
                    <InputField label="Año Modelo" value={anoModelo} name="anoModelo" placeholder="Ingrese el año del modelo" type='number' handleChange={handleChange} />
                    <InputField label="Marca" value={marca} name="marca" type='text' placeholder="Ingrese la marca" handleChange={handleChange} />
                </div>
                <div className="flex gap-4 ">
                    <InputField label="Cilindraje CC" value={cilindrajeCC} name="cilindrajeCC" placeholder="Ingrese el cilindraje CC" type='text' handleChange={handleChange} />
                    <InputField label="Placa matricula" value={placaMatricula} name="placaMatricula" type='text' placeholder="Ingrese su placa de matricula" handleChange={handleChange} />
                </div>
                <div className="flex gap-4 ">
                    <InputField label="Fecha Expedicion SOAT" value={fechaExpedicionSOAT} name="fechaExpedicionSOAT" type='date' placeholder="Ingrese su nombre" handleChange={handleChange} />
                    <InputField label="Fecha de expedicion licencia conduccion" value={fechaExpedicionLicenciaConduccion} name="fechaExpedicionLicenciaConduccion" placeholder="Ingrese su nombre" type='date' handleChange={handleChange} />
                </div>
                <div className="flex gap-4">
                    <button type='submit' className="bg-green-500 hover:bg-green-400 p-3 rounded-lg text-white cursor-pointer ">
                        Enviar
                    </button>
                    <button onClick={handleClickUpdate} className="bg-amber-700 hover:bg-amber-600 p-3 rounded-lg text-white cursor-pointer">
                        Actualizar
                    </button>
                    <button onClick={handleClickUpdate} className="bg-red-500 hover:bg-red-400 p-3 rounded-lg text-white cursor-pointer">
                        Eliminar
                    </button>
                </div>
            </form>
        </div>
    )
}