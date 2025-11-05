import type { FormEvent } from "react"
import { InputField } from "../components/InputField";
import { InputList } from "../components/InputList";

export const Register = () => {
    const rhTypes = [{ text: 'A+', value: 'A+' }, { text: 'A-', value: 'A-' }, { text: 'B', value: 'B' }, { text: 'B-', value: 'B-' }, { text: 'AB+', value: 'AB+' }, { text: 'O', value: 'O' }];
    const handleSubmit = (e: FormEvent<HTMLFormElement>) => {
        e.preventDefault();
    }
    return (
        <div>
            <form onSubmit={handleSubmit} className="flex flex-col gap-3">
                <div className="flex gap-4 ">
                    <InputField label="Nombre" name="Nombre" placeholder="Ingrese su nombre" handleChange={() => { }} />
                    <InputField label="Apellido" name="Apellido" placeholder="Ingrese su nombre" handleChange={() => { }} />
                    <InputField label="Celular" name="Nombre" placeholder="Ingrese su nombre" handleChange={() => { }} />
                </div>
                <div className="flex gap-4 ">
                    <InputField label="Correo Electronico" name="CorreoElectronico" placeholder="Ingrese su nombre" handleChange={() => { }} />
                    <InputField label="Fecha de Ingreso" name="FechaIngreso" placeholder="Ingrese su nombre" handleChange={() => { }} />
                    <InputField label="Direccion" name="Direccion" placeholder="Ingrese su nombre" handleChange={() => { }} />
                </div>
                <div className="flex gap-4 ">
                    <InputField label="Miembro" name="Member" placeholder="Ingrese su nombre" handleChange={() => { }} />
                    <InputField label="Cargo" name="Cargo" placeholder="Ingrese su nombre" handleChange={() => { }} />
                    <InputField label="Rango" name="Rango" placeholder="Ingrese su nombre" handleChange={() => { }} />
                </div>

                <div className="flex gap-4 ">
                    <InputField label="Estatus" name="Estatus" placeholder="Ingrese su nombre" handleChange={() => { }} />
                    <InputField label="Fecha de Nacimiento" name="FechaNacimiento" type='date' placeholder="Ingrese su nombre" handleChange={() => { }} />
                    <InputField label="Cedula" name="Cedula" placeholder="Ingrese su nombre" handleChange={() => { }} />
                </div>
                <div className="flex gap-4">
                    <InputList label='RH' name="RH" handleChange={() => { }} options={rhTypes} />
                    <InputField label="EPS" name="EPS" placeholder="Ingrese su nombre" handleChange={() => { }} />
                    <InputField label="Padrino" name="Padrino" type='text' placeholder="Ingrese su nombre" handleChange={() => { }} />
                </div>
                <div className="flex gap-4 ">
                    <InputField label="Foto" name="Foto" placeholder="Ingrese su nombre" type='file' accept="image/*" handleChange={() => { }} />
                    <InputField label="Contacto de emergencia" name="ContactoEmergencia" type='text' placeholder="Ingrese su nombre" handleChange={() => { }} />
                    <InputField label="Ciudad" name="Ciudad" placeholder="Ingrese su nombre" type='text' handleChange={() => { }} />
                </div>
                <div className="flex gap-4 ">
                    <InputField label="Moto" name="Moto" type='text' placeholder="Ingrese su nombre" handleChange={() => { }} />
                    <InputField label="Año Modelo" name="AnoModelo" placeholder="Ingrese su nombre" type='number' handleChange={() => { }} />
                    <InputField label="Marca" name="Marca" type='text' placeholder="Ingrese su nombre" handleChange={() => { }} />
                </div>
                <div className="flex gap-4 ">
                    <InputField label="Cilindraje CC" name="CilindrajeCC" placeholder="Ingrese su nombre" type='text' handleChange={() => { }} />
                    <InputField label="Placa matricula" name="PlacaMatricula" type='text' placeholder="Ingrese su nombre" handleChange={() => { }} />
                    <InputField label="Fecha de expedicion licencia conduccion" name="FechaExpedicionLicenciaConduccion" placeholder="Ingrese su nombre" type='date' handleChange={() => { }} />
                </div>
                <div className="flex gap-4 ">
                    <InputField label="Fecha Expedicion SOAT" name="FechaExpedicionSOAT" type='date' placeholder="Ingrese su nombre" handleChange={() => { }} />
                    <InputField label="Fecha de expedicion licencia conduccion" name="FechaExpedicionLicenciaConduccion" placeholder="Ingrese su nombre" type='date' handleChange={() => { }} />
                </div>
            </form>
        </div>
    )
}