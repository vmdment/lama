import type { ChangeEventHandler, HTMLInputTypeAttribute } from "react";

type Props = {
    value?: string | number | string[];
    name: string;
    handleChange: ChangeEventHandler<HTMLElement>;
    label: string;
    placeholder?: string;
    type?: HTMLInputTypeAttribute;
    accept?: string;
}
export const InputField = ({ label, value, name, handleChange, placeholder, type = 'text', accept }: Props) => {
    return (
        <div className="flex flex-col gap-1 w-full">
            <label htmlFor={name} className="font-semibold">{label}:</label>
            <input id={name} type={type} value={value} name={name} onChange={handleChange} placeholder={placeholder} accept={accept} className="placeholder:pl-1 pl-1 border border-blue-400 rounded-lg h-9" />
        </div>
    )
}