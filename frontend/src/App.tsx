import { BrowserRouter, Route, Routes } from 'react-router'
import { Index } from './pages/Index'
import { ListMembers } from './pages/ListMembers'
import { UpdateMember } from './pages/UpdateMember'
import { PublicLayout } from './pages/layouts/PublicLayout'
import './App.css'

export const App = () => {

  return (
    <BrowserRouter>
      <Routes>
        <Route element={<PublicLayout />}>
          <Route path='/' element={<Index />} />
          <Route path='/list-member' element={<ListMembers />} />
          <Route path='/update-member' element={<UpdateMember />} />
        </Route>
      </Routes>
    </BrowserRouter>
  )
}