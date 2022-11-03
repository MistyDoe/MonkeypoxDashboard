import { useEffect, useState } from "react";
import Graph from "./Graph";
import Dropdown from "react-bootstrap/Dropdown";
import DropdownToggle from "react-bootstrap/esm/DropdownToggle";

export default function CountryList() {
	const [loading, setLoading] = useState(false);
	const [countryList, setCountryList] = useState();
	const [selectedCountry, setSelectedCountry] = useState();
	const [countrySent, setCountrySent] = useState();
	const [closed, setClosed] = useState(true);

	useEffect(() => {
		fetch("http://localhost:5152/api/Case")
			.then((res) => res.json())
			.then((json) => {
				setCountryList(json);
				setLoading(true);
				setClosed(false);
				console.log(countryList);
			});
	}, []);

	const handleCountrySelect = (country) => {
		setSelectedCountry(country);
		console.log(selectedCountry + "selected");
	};

	useEffect(() => {
		setCountrySent(selectedCountry);
		console.log(countrySent);
	}, [selectedCountry]);

	if (loading === false) {
		return <></>;
	}
	return (
		<>
			{
				<Dropdown>
					<Dropdown.Toggle>Country List</Dropdown.Toggle>
					<Dropdown.Menu>
						{countryList.map((country) => (
							<Dropdown.Item
								value={country}
								onClick={() => handleCountrySelect(country)}
							>
								<button>{country}</button>
							</Dropdown.Item>
						))}
					</Dropdown.Menu>
				</Dropdown>
			}
			<Graph country={countrySent} />
		</>
	);
}
