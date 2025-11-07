import { useState } from "react"
import { MembersContext } from "./MemberContext"
import type { Member } from "../models/Member";

type Props = {
    children: React.ReactNode;
}
export const MemberProvider = ({ children }: Props) => {
    const [members, setMembers] = useState<Member[]>([]);
    return (
        <MembersContext.Provider value={{ members, setMembers }}>
            {children}
        </MembersContext.Provider>
    )
}