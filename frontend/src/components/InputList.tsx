import type { ChangeEventHandler } from "react";

type Props = {
    name: string;
    label: string;
    value: string | number;
    handleChange: ChangeEventHandler<HTMLSelectElement>;
    options?: { text: string, value: string }[]
}
export const InputList = ({ name, label, value, handleChange, options = [] }: Props) => {
    return (
        <div className="flex flex-col gap-2">
            <label htmlFor={name} className="font-bold">{label}</label>
            <select id={name} name={name} value={value} onChange={handleChange} className="border border-blue-400 rounded-lg h-8 cursor-pointer w-52">
                {options.map(({ text, value }) => (<option key={value} value={value}>{text}</option>))}
            </select>
        </div>
    )
}